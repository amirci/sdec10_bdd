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
        /// Call create method
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Create();
        }
    }
}