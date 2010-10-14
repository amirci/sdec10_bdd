using MvcContrib.TestHelper;
using MavenThought.Commons.Testing;

namespace MavenThought.MediaLibrary.WebClient.Tests.Controllers
{
    /// <summary>
    /// Specification when calling create method
    /// </summary>
    [Specification]
    public class When_movies_controller_creates_the_form_to_add_a_movie : MoviesControllerSpecification
    {
        /// <summary>
        /// Checks the view with the form is returned
        /// </summary>
        [It]
        public void Should_return_the_create_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Call create method
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Create();
        }
    }
}