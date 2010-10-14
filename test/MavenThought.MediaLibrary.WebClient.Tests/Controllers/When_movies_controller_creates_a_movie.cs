using MavenThought.MediaLibrary.Domain;
using Rhino.Mocks;
using MavenThought.Commons.Testing;
using MvcContrib.TestHelper;

namespace MavenThought.MediaLibrary.WebClient.Tests.Controllers
{
    /// <summary>
    /// Specification when calling create method to submit information
    /// </summary>
    [Specification]
    public class When_movies_controller_creates_a_movie : MoviesControllerSpecification
    {
        /// <summary>
        /// Checks that the page is redirected to Index
        /// </summary>
        [It]
        public void Should_redirect_to_index_page()
        {
            this.ActualResult.AssertHttpRedirect().ToUrl("Index");
        }

        /// <summary>
        /// Checks that the movie was added to the library
        /// </summary>
        [It]
        public void Should_add_the_movie_to_the_library()
        {
            var args = Arg<IMovie>.Matches(m => m.Title == "Some Title");

            Dep<IMediaLibrary>().AssertWasCalled(lib => lib.Add(args));
        }

        /// <summary>
        /// Call create to submit information
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Create("Some Title");
        }
    }
}