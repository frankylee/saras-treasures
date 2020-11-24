﻿using System;
using System.Linq;
using SarasTreasures.Controllers;
using SarasTreasures.Models;
using SarasTreasures.Repos;
using Xunit;

namespace Tests
{
    public class StoryTests
    {
        // instance variables
        private FakeStoryRepository fakeRepo;
        private RescueController controller;
        private Story story;


        // constructor behaves the same as [SetUp]
        public StoryTests()
        {
            fakeRepo = new FakeStoryRepository();
            controller = new RescueController(fakeRepo);
            story = new Story()
            {
                Title = "Pineapple",
                UserName = new User() { Name = "Suzie Q" },
                Text = "Lorem ipsum dolor sit amet",
                FileName = "30721.jpg",
            };
        }

        [Fact]
        public void AddStoryTest()
        {
            // add new story object
            controller.HappyTail(story);

            // Assert new story object was added to fake repo
            // while simultaneously testing GetStoryByTitle()
            Story retrievedStory = fakeRepo.GetStoryByTitle("Pineapple");
            Assert.Equal(story, retrievedStory);

            // Assert date was added to story object
            Assert.Equal(0, DateTime.Now.Date.CompareTo(retrievedStory.Date.Date));
        }
    }
}