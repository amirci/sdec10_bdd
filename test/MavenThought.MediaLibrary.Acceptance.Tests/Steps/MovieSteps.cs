using System;
using MavenThought.MediaLibrary.Acceptance.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Steps related to movie
    /// </summary>
    [Binding]
    public class MovieSteps
    {
        /// <summary>
        /// Movie page object
        /// </summary>
        private readonly AddMoviePage _page;

        /// <summary>
        /// Initialize an instance
        /// </summary>
        public MovieSteps()
        {
            this._page = new AddMoviePage();
        }

        /// <summary>
        /// Enter a title into the movie
        /// </summary>
        /// <param name="title">Title of the movie</param>
        [When(@"I enter ""(.*)"" in the title")]
        public void EnterMovieTitle(string title)
        {
            this._page.Title = title;
        }

        [When(@"I click ""Submit""")]
        public void ClickSubmit()
        {
            this._page.Submit();
        }
    }
}