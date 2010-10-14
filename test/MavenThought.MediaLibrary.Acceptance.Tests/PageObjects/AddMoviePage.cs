using MavenThought.MediaLibrary.Acceptance.Tests.Utility;

namespace MavenThought.MediaLibrary.Acceptance.Tests.PageObjects
{
    /// <summary>
    /// Page to abstract add movies page implementation on the web application
    /// </summary>
    public class AddMoviePage
    {
        /// <summary>
        /// Gets or sets the title on the page
        /// </summary>
        public string Title
        {
            get { return Browser.Instance.TextField("title").Value; }

            set { Browser.Instance.TextField("title").Value = value ; }
        }

        /// <summary>
        /// Click the submit button to send the form
        /// </summary>
        public void Submit()
        {
            Browser.Instance.Button("Submit").Click();
        }
    }
}