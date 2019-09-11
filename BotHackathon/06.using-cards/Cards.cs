// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Microsoft.BotBuilderSamples
{
    public static class Cards
    {
        public static Attachment CreateAdaptiveCardAttachment()
        {
            // combine path for cross platform support
            string[] paths = { ".", "Resources", "adaptiveCard.json" };
            var adaptiveCardJson = File.ReadAllText(Path.Combine(paths));

            var adaptiveCardAttachment = new Attachment()
            {
                ContentType = "application/vnd.microsoft.card.adaptive",
                Content = JsonConvert.DeserializeObject(adaptiveCardJson),
            };
            return adaptiveCardAttachment;
        }

        public static HeroCard GetHeroCard()
        {
            var heroCard = new HeroCard
            {
                Title = "BotFramework Hero Card",
                Subtitle = "Microsoft Bot Framework",
                Text = "Build and connect intelligent bots to interact with your users naturally wherever they are," +
                       " from text/sms to Skype, Slack, Office 365 mail and other popular services.",
                Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Get Started", value: "https://docs.microsoft.com/bot-framework") },
            };

            return heroCard;
        }

        public static ThumbnailCard GetThumbnailCard()
        {
            var heroCard = new ThumbnailCard
            {
                Title = "BotFramework Thumbnail Card",
                Subtitle = "Microsoft Bot Framework",
                Text = "Build and connect intelligent bots to interact with your users naturally wherever they are," +
                       " from text/sms to Skype, Slack, Office 365 mail and other popular services.",
                Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Get Started", value: "https://docs.microsoft.com/bot-framework") },
            };

            return heroCard;
        }

        public static ReceiptCard GetReceiptCard()
        {
            var receiptCard = new ReceiptCard
            {
                Title = "John Doe",
                Facts = new List<Fact> { new Fact("Order Number", "1234"), new Fact("Payment Method", "VISA 5555-****") },
                Items = new List<ReceiptItem>
                {
                    new ReceiptItem(
                        "Data Transfer",
                        price: "$ 38.45",
                        quantity: "368",
                        image: new CardImage(url: "https://github.com/amido/azure-vector-icons/raw/master/renders/traffic-manager.png")),
                    new ReceiptItem(
                        "App Service",
                        price: "$ 45.00",
                        quantity: "720",
                        image: new CardImage(url: "https://github.com/amido/azure-vector-icons/raw/master/renders/cloud-service.png")),
                },
                Tax = "$ 7.50",
                Total = "$ 90.95",
                Buttons = new List<CardAction>
                {
                    new CardAction(
                        ActionTypes.OpenUrl,
                        "More information",
                        "https://account.windowsazure.com/content/6.10.1.38-.8225.160809-1618/aux-pre/images/offer-icon-freetrial.png",
                        value: "https://azure.microsoft.com/en-us/pricing/"),
                },
            };

            return receiptCard;
        }

        public static SigninCard GetSigninCard()
        {
            var signinCard = new SigninCard
            {
                Text = "BotFramework Sign-in Card",
                Buttons = new List<CardAction> { new CardAction(ActionTypes.Signin, "Sign-in", value: "https://login.microsoftonline.com/") },
            };

            return signinCard;
        }

        public static AnimationCard GetAnimationCard()
        {
            var animationCard = new AnimationCard
            {
                Title = "Microsoft Bot Framework",
                Subtitle = "Animation Card",
                Image = new ThumbnailUrl
                {
                    Url = "https://docs.microsoft.com/en-us/bot-framework/media/how-it-works/architecture-resize.png",
                },
                Media = new List<MediaUrl>
                {
                    new MediaUrl()
                    {
                        Url = "http://i.giphy.com/Ki55RUbOV5njy.gif",
                    },
                },
            };

            return animationCard;
        }


        static Dictionary<string, string[]> states = new Dictionary<string, string[]>(){
            {"Happy", new string[]{"https://www.youtube.com/watch?v=LjhCEhWiKXk&list=PL1VuYyZcPYIJTP3W_x0jq9olXviPQlOe1&index=1",
                                    "https://www.youtube.com/watch?v=ru0K8uYEZWw&list=RDQMNKED_0Rpx4g&start_radio=1",
                                    "https://www.youtube.com/watch?v=JR49dyo-y0E&list=PLinS5uF49IBo8HLKBDAjQaeiN4TjHi75Q",
                                    "https://www.youtube.com/watch?v=ir6nk2zrMG0&list=RDQMZIcHoO5qgSg&start_radio=1"}},
                                    
            {"Angry", new string[]{"https://www.youtube.com/watch?v=xnKhsTXoKCI&list=PLhQCJTkrHOwSX8LUnIMgaTq3chP1tiTut",
                                    "https://www.youtube.com/watch?v=CSvFpBOe8eY&list=PLGBuKfnErZlD_VXiQ8dkn6wdEYHbC3u0i",
                                    "https://www.youtube.com/watch?v=CD-E-LDc384&list=PLfY-m4YMsF-OM1zG80pMguej_Ufm8t0VC",
                                    "https://www.youtube.com/watch?v=ZLk75fFXqH4&list=PLRsjjflA5zwHv3G-58ePGHPywul8SZqTh"}},

            {"Chill", new string[]{"https://www.youtube.com/watch?v=jO2viLEW-1A&list=RDQMOE8XiyF2cWw&start_radio=1",
                                    "https://www.youtube.com/watch?v=uJ_1HMAGb4k&list=RDQMOE8XiyF2cWw&index=5",
                                    "https://www.youtube.com/watch?v=iX-QaNzd-0Y&list=RDQMOE8XiyF2cWw&index=12",
                                    "https://www.youtube.com/watch?v=Kp7eSUU9oy8&list=RDQMOE8XiyF2cWw&index=34"}},

            {"Pumped", new string[]{"https://www.youtube.com/watch?v=ALZHF5UqnU4&list=PLFPg_IUxqnZNnACUGsfn50DySIOVSkiKI&index=4",
                                    "https://www.youtube.com/watch?v=1-xGerv5FOk&list=PLFPg_IUxqnZNnACUGsfn50DySIOVSkiKI&index=24",
                                    "https://www.youtube.com/watch?v=eH4F1Tdb040&list=PLFPg_IUxqnZNnACUGsfn50DySIOVSkiKI&index=88",
                                    "https://www.youtube.com/watch?v=y6120QOlsfU&list=PLFPg_IUxqnZNnACUGsfn50DySIOVSkiKI&index=159"}},

            {"Sad", new string[]{"https://www.youtube.com/watch?v=bo_efYhYU2A&list=PL5D7fjEEs5yflZzSZAhxfgQmN6C_6UJ1W",
                                    "https://www.youtube.com/watch?v=zGRSjJC7Lek&list=PLv8jGqwQoxR8KJGT7ZuSleCCAZq5ZKuwN",
                                    "https://www.youtube.com/watch?v=8ofCZObsnOo&list=PLgzTt0k8mXzHcKebL8d0uYHfawiARhQja",
                                    "https://www.youtube.com/watch?v=7TWzV05kQ4w&list=PLkas6B2O0bmZ1XdWqAkAsiTYHE-rGLBB6",
                                    "https://www.youtube.com/watch?v=5R1RGl4WQP8&list=PL6ykWMybidv6MVd92KXACvN9aI-0EtZBE"}}
        };
        public static VideoCard getCardFromState(string state){
            return GetVideoCard(states[state][new Random().Next(states[state].Length)]);
        }
        public static VideoCard GetVideoCard(string url)
        {
            var videoCard = new VideoCard
            {   
                Image = new ThumbnailUrl
                {
                    Url = "https://www.youtube.com/watch?v=LjhCEhWiKXk&list=PL1VuYyZcPYIJTP3W_x0jq9olXviPQlOe1&index=1",
                },
                Media = new List<MediaUrl>
                {
                    new MediaUrl()
                    {
                        Url = url,
                    },
                },
                Buttons = new List<CardAction>
                {
                    new CardAction()
                    {
                        Title = "Learn More",
                        Type = ActionTypes.OpenUrl,
                        Value = "https://peach.blender.org/",
                    },
                },
            };
            return videoCard;
        }

        public static AudioCard GetAudioCard()
        {
            var audioCard = new AudioCard
            {
                Title = "I am your father",
                Subtitle = "Star Wars: Episode V - The Empire Strikes Back",
                Text = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back)" +
                       " is a 1980 American epic space opera film directed by Irvin Kershner. Leigh Brackett and" +
                       " Lawrence Kasdan wrote the screenplay, with George Lucas writing the film's story and serving" +
                       " as executive producer. The second installment in the original Star Wars trilogy, it was produced" +
                       " by Gary Kurtz for Lucasfilm Ltd. and stars Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams," +
                       " Anthony Daniels, David Prowse, Kenny Baker, Peter Mayhew and Frank Oz.",
                Image = new ThumbnailUrl
                {
                    Url = "https://upload.wikimedia.org/wikipedia/en/3/3c/SW_-_Empire_Strikes_Back.jpg",
                },
                Media = new List<MediaUrl>
                {
                    new MediaUrl()
                    {
                        Url = "http://www.wavlist.com/movies/004/father.wav",
                    },
                },
                Buttons = new List<CardAction>
                {
                    new CardAction()
                    {
                        Title = "Read More",
                        Type = ActionTypes.OpenUrl,
                        Value = "https://en.wikipedia.org/wiki/The_Empire_Strikes_Back",
                    },
                },
            };

            return audioCard;
        }
    }
}
