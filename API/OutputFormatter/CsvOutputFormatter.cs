using Assignment2.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Globalization;
using System.Text;

namespace API.OutputFormatter
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public string ContentType { get; } = "text/csv";

        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(ContentType);
            SupportedEncodings.Add(Encoding.UTF8);
        }

        protected override bool CanWriteType(Type? type)
        {
            if (typeof(MedicalFacility).IsAssignableFrom(type) || typeof(IEnumerable<MedicalFacility>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context,
            Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;

            var csv = new CsvWriter(new StreamWriter(response.Body), CultureInfo.InvariantCulture);

            IEnumerable<MedicalFacility> facilities;

            if (context.Object is IEnumerable<MedicalFacility>)
            {
                facilities = context.Object as IEnumerable<MedicalFacility>;
            }
            else
            {
                var facility = context.Object as MedicalFacility;
                facilities = new List<MedicalFacility> { facility };
            }
            await csv.WriteRecordsAsync(facilities);
        }
    }
}
