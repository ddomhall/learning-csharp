using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunGroopWebApp.Controllers;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Tests.ControllerTests
{
    public class ClubControllerTests
    {
        private IClubRepository _clubRepository;
        private IPhotoService _photoService;
        private IHttpContextAccessor _httpContextAccessor;
        private ClubController _clubController;
        public ClubControllerTests()
        {
            _clubRepository = A.Fake<IClubRepository>();
            _photoService = A.Fake<IPhotoService>();
            _httpContextAccessor = A.Fake<IHttpContextAccessor>();

            _clubController = new ClubController(_clubRepository, _photoService, _httpContextAccessor);
        }

        [Fact]
        public void ClubController_Index_ReturnsSuccess()
        {
            var clubs = A.Fake<IEnumerable<Club>>();
            A.CallTo(() => _clubRepository.GetAll()).Returns(clubs);

            var result = _clubController.Index();

            result.Should().BeOfType<Task<IActionResult>>();
        }

        [Fact]
        public void ClubController_Detail_ReturnsSuccess()
        {
            var id = 1;
            var club = A.Fake<Club>();
            A.CallTo(() => _clubRepository.GetByIdAsync(id)).Returns(club);

            var result = _clubController.Detail(id);

            result.Should().BeOfType<Task<IActionResult>>();
        }
    }
}
