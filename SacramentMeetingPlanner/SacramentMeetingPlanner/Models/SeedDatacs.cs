using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SacramentMeetingPlannerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SacramentMeetingPlannerContext>>()))
        {
            // Look for any movies.
            if (context.Planner.Any())
            {
                return;   // DB has been seeded
            }

            if (context.SpeachTopic.Any())
            {
                return;   // DB has been seeded
            }

            context.Planner.AddRange(
                new Planner
                {
                    MeetingDate = DateTime.Parse("1984-3-13"),
                    PresideLeader = "William Meza",
                    ConductingLeader = "Jose Alarcon",
                    OpeningSong = 84,
                    OpeningPray = "Mario Castaneda",
                    SacramentHymn = 120,
                    SpeakerSubject = "The holypath covenant",
                    ClosingSong = 102,
                    ClosingPray = "Luigi"
                },
                new Planner
                {
                    MeetingDate = DateTime.Parse("2023-3-13"),
                    PresideLeader = "Julio Panson",
                    ConductingLeader = "Estefan Quiroz",
                    OpeningSong = 50,
                    OpeningPray = "Samuel Umtiti",
                    SacramentHymn = 06,
                    SpeakerSubject = "The Sabbath Day",
                    ClosingSong = 50,
                    ClosingPray = "Carla Mariano"
                },
                new Planner
                {
                    MeetingDate = DateTime.Parse("2022-8-25"),
                    PresideLeader = "Santiago Ortigoza",
                    ConductingLeader = "Emiliano Martinez",
                    OpeningSong = 44,
                    OpeningPray = "Daniel Osma",
                    SacramentHymn = 135,
                    SpeakerSubject = "Thiting",
                    ClosingSong = 113,
                    ClosingPray = "Maria Balde"
                },
                new Planner
                {
                    MeetingDate = DateTime.Parse("2020-5-10"),
                    PresideLeader = "Emilio Ortega",
                    ConductingLeader = "Juan Quiroz",
                    OpeningSong = 05,
                    OpeningPray = "Andry Cortizo",
                    SacramentHymn = 60,
                    SpeakerSubject = "The law of chastity",
                    ClosingSong = 120,
                    ClosingPray = "Carla Martinez"
                }
            );

            context.SpeachTopic.AddRange(
                new SpeachTopic { 
                    TopicName = "Atonement" 
                },
                new SpeachTopic
                {
                    TopicName = "Baptism"
                },
                new SpeachTopic
                {
                    TopicName = "Charity"
                },
                new SpeachTopic
                {
                    TopicName = "Faith"
                },
                new SpeachTopic
                {
                    TopicName = "Forgiveness"
                },
                new SpeachTopic
                {
                    TopicName = "Hope"
                },
                new SpeachTopic
                {
                    TopicName = "Missionary Work"
                },
                new SpeachTopic
                {
                    TopicName = "Repentance"
                },
                new SpeachTopic
                {
                    TopicName = "Service"
                },
                new SpeachTopic
                {
                    TopicName = "Temple"
                },
                new SpeachTopic
                {
                    TopicName = "Zion"
                }
            );

            context.SaveChanges();
        }
    }
}