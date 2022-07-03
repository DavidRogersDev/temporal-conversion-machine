using DateConverter.Infrastructure;
using System.Text.Json;

namespace DateConverter.Tests
{
    public class TimeServiceIntegrationTests
    {
        private const string Dhaka = @"Asia/Dhaka";
        private const string Anchorage = @"America/Anchorage";
        const string AlaskanStandardTime = "Alaskan Standard Time";
        const string WorldTimeApiBaseAddress = @"http://worldtimeapi.org/api/timezone/";

        [Fact]
        public async void ZoneOffset_Returns_Current_Time_For_TimZone()
        {
            var timeService = new TimeService();

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(WorldTimeApiBaseAddress);

            var rawData = await client.GetStringAsync(Anchorage);

            var timeDataFromAPI = JsonSerializer.Deserialize<TimeDto>(rawData);


            var alaskanTime = timeService.ConvertToZonedOffset(timeDataFromAPI.datetime, AlaskanStandardTime);

            Assert.Equal(alaskanTime, timeDataFromAPI.datetime);
        }

        [Fact]
        public async void GetOffsetForZone_Returns_Correct_Offset()
        {
            var timeService = new TimeService();

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(WorldTimeApiBaseAddress);

            var rawData = await client.GetStringAsync(Anchorage);

            var timeDataFromAPI = JsonSerializer.Deserialize<TimeDto>(rawData);

            var offset = timeService.GetOffsetForZone(AlaskanStandardTime, DateTime.Now);

            Assert.Equal(timeDataFromAPI.datetime.Offset, offset);
        }
    }
}