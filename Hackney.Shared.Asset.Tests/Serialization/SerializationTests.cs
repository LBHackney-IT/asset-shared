using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Hackney.Shared.Asset.Serialization;
using Xunit;
using Newtonsoft.Json;
using FluentAssertions;

namespace Hackney.Shared.Asset.Tests.Serialization
{
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OldEnum
    {
        Dwelling
    }

    [Newtonsoft.Json.JsonConverter(typeof(SafeStringEnumConverter), NotFound)]
    public enum NewEnum
    {
        Dwelling,
        NotFound
    }

    public class TestModelOld
    {
        public OldEnum TestEnum { get; set; }
        public string TestValue { get; set; }
    }

    public class TestModelNew
    {
        public NewEnum TestEnum { get; set; }
        public string TestValue { get; set; }
    }

    public class SerializationTests
    {
        [Fact]
        public async Task OldJsonConverter_WhenEnumExists_DeserializesJson()
        {
            // Arrange
            var requestJson = "{\"TestValue\":\"Dummy Text\",\"TestEnum\":\"Dwelling\"}";

            // Act
            var result = JsonConvert.DeserializeObject<TestModelOld>(requestJson);

            // Assert
            result.TestEnum.Should().Be(OldEnum.Dwelling);
        }

        [Fact]
        public async Task OldJsonConverter_WhenEnumDoesntExist_ThrowsException()
        {
            // Arrange
            var requestJson = "{\"TestValue\":\"Dummy Text\",\"TestEnum\":\"InvalidEnum\"}";

            // Act
            Func<TestModelOld> func = () => JsonConvert.DeserializeObject<TestModelOld>(requestJson);

            // Assert
            func.Should().Throw<JsonSerializationException>();
        }

        [Fact]
        public async Task NewJsonConverter_WhenEnumExists_DeserializesJson()
        {
            // Arrange
            var requestJson = "{\"TestValue\":\"Dummy Text\",\"TestEnum\":\"Dwelling\"}";

            // Act
            var result = JsonConvert.DeserializeObject<TestModelNew>(requestJson);

            // Assert
            result.TestEnum.Should().Be(NewEnum.Dwelling);
        }


        [Fact]
        public async Task NewJsonConverter_WhenEnumDoesntExist_UsesDefaultValue()
        {
            // Arrange
            var requestJson = "{\"TestValue\":\"Dummy Text\",\"TestEnum\":\"Dxwellingg\"}";

            // Act
            var result = JsonConvert.DeserializeObject<TestModelNew>(requestJson);

            // Assert
            result.TestEnum.Should().Be(NewEnum.NotFound);
        }


        [Fact]
        public async Task OldJsonConverter_WhenSerialized_ReturnsEnumAsNumber()
        {
            // Arrange
            var model = new TestModelOld
            {
                TestEnum = OldEnum.Dwelling,
                TestValue = "test"
            };

            // Act
            var result = JsonConvert.SerializeObject(model);

            // Assert
            var expectedJson = $"{{\"TestEnum\":0,\"TestValue\":\"test\"}}";

            result.Should().Be(expectedJson);
        }

        [Fact]
        public async Task NewJsonConverter_WhenSerialized_ReturnsEnumAsString()
        {
            // Arrange
            var model = new TestModelNew
            {
                TestEnum = NewEnum.Dwelling,
                TestValue = "test"
            };

            // Act
            var result = JsonConvert.SerializeObject(model);

            // Assert
            var expectedJson = $"{{\"TestEnum\":\"Dwelling\",\"TestValue\":\"test\"}}";

            result.Should().Be(expectedJson);
        }
    }
}
