using Dicta_Sanctorum.Data.Repository;
using Dicta_Sanctorum.Models;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicta_Sanctorium.Test
{
    public class SaintRepositoryTest
    {
        SaintsRepository _saintsRepository;
        IConfiguration _configuration;

        [SetUp]
        public void Setup()
        {
            _saintsRepository = new SaintsRepository(_configuration);
        }

        [Test]
        public void GetAllSaints()
        {
            //Arrange


            //Act

            //Assert
            NUnit.Framework.Assert.Fail();
        }

        [Test]
        public void GetSaintById()
        {
            //Arrange


            //Act

            //Assert
            NUnit.Framework.Assert.Fail();
        }

        [Test]
        public void AddSaint()
        {
            //Arrange
            var saint = new SaintModel()
            {
                name = "Saint Name",
                bio = "Saint Bio",
                feastDay = DateTime.Now,
                birthYear = DateTime.MinValue,
                deathYear = DateTime.MinValue,
                canonizationYear = DateTime.MinValue,
                image = "Saint Image",
            };

            //Act
            //Assert
            NUnit.Framework.Assert.DoesNotThrow(() => { _saintsRepository.Add(saint); });
        }

        [Test]
        public void AddAndReturnSaintId()
        {
            //Arrange
            var saint = new SaintModel()
            {
                name = "Saint Name",
                bio = "Saint Bio",
                feastDay = DateTime.Now,
                birthYear = DateTime.MinValue,
                deathYear = DateTime.MinValue,
                canonizationYear = DateTime.MinValue,
                image = "Saint Image",
            };

            //Act
            var id = _saintsRepository.AddAndReturnId(saint);

            //Assert
            NUnit.Framework.Assert.That(id, Is.GreaterThan(0));
        }

        [Test]
        public void EditSaint()
        {
            //Arrange


            //Act

            //Assert
            NUnit.Framework.Assert.Fail();
        }

        [Test]
        public void DeleteSaint()
        {
            //Arrange


            //Act

            //Assert
            NUnit.Framework.Assert.Fail();
        }


        [TearDown]
        public void TearDown()
        {
            _saintsRepository = null;
        }
    }
}
