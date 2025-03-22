using Dicta_Sanctorum.Api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicta_Sanctorum.API.Tests
{
    public class PhraseControllerTest
    {
        private PhraseController _phraseController;

        public PhraseControllerTest()
        {
            _phraseController = new PhraseController();
        }

        [Fact]
        public async Task GetRandom_ShouldReturnPhrase()
        {
            //act
            var result= await _phraseController.GetRandom();

            //assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetById_ShouldReturnPhrase_WhenIdIsValid()
        {
            //arrage
            int id=1;
            
            //act
            var result= await _phraseController.GetPhraseById(id);

            //assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<OkObjectResult>();

            var okResult = result.Result as OkObjectResult;
            okResult.Value.Should().Be(_phraseController.listPhrases[id - 1]);

        }


        [Theory]
        [InlineData(0)]  // ID inválido (menor que 1)
        [InlineData(999)]  // ID muito alto (não existe)
        public async Task GetPhraseById_ShouldReturnBadRequest_WhenIdIsInvalid(int id)
        {
            // Act
            var result = await _phraseController.GetPhraseById(id);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<BadRequestObjectResult>();
        }


        [Fact]
        public void CreateNewPhrase_ShouldReturnOk_WhenPhraseIsValid()
        {
            // Arrange
            string newPhrase = "Nova frase de teste";

            // Act
            var result = _phraseController.CreateNewPhrase(newPhrase);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void CreateNewPhrase_ShouldReturnBadRequest_WhenPhraseIsEmpty()
        {
            // Act
            var result = _phraseController.CreateNewPhrase("");

            // Assert
            result.Should().BeOfType<BadRequestObjectResult>();
        }

        [Fact]
        public void UpdatePhrase_ShouldReturnOk_WhenDataIsValid()
        {
            // Arrange
            string updatedPhrase = "Frase atualizada";
            int validId = 1;

            // Act
            var result = _phraseController.UpdatePhrase(validId, updatedPhrase);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }

        [Theory]
        [InlineData(0)]  // ID inválido
        [InlineData(999)]  // ID muito alto
        public void UpdatePhrase_ShouldReturnBadRequest_WhenIdIsInvalid(int id)
        {
            // Arrange
            string updatedPhrase = "Frase nova";

            // Act
            var result = _phraseController.UpdatePhrase(id, updatedPhrase);

            // Assert
            result.Should().BeOfType<BadRequestObjectResult>();
        }

        [Fact]
        public void DeletePhrase_ShouldReturnOk_WhenIdIsValid()
        {
            // Arrange
            int validId = 1;

            // Act
            var result = _phraseController.DeletePhrase(validId);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }

        [Theory]
        [InlineData(0)]  // ID inválido
        [InlineData(999)]  // ID não existente
        public void DeletePhrase_ShouldReturnBadRequest_WhenIdIsInvalid(int id)
        {
            // Act
            var result = _phraseController.DeletePhrase(id);

            // Assert
            result.Should().BeOfType<BadRequestObjectResult>();
        }
    }
}
