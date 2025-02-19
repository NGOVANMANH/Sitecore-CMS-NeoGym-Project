using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySite.Feature.PageContent
{
    public class Templates
    {
        public readonly struct Information
        {
            public const string Id = "{9BA855D0-A81E-4044-B482-BF4CE0F50435}";
            public readonly struct Fields
            {
                public const string Content = "{29B20E77-6DAD-4074-8BD5-CCD3CE857FF1}";
                public const string Image = "{ABE8B645-B3A8-46BD-A848-CDCAFD9D051A}";
                public const string Url = "{C68CDD16-A629-4DCE-9657-62F543A869FB}";
            }
        }

        public readonly struct Why
        {
            public const string Id = "{AAD6C31E-4744-498E-A49F-FC50A0850DCC}";
            public readonly struct Fields
            {
                public const string Title = "{DE076334-D20F-469A-A6FF-917C2329E601}";
                public const string Description = "{B82999D6-B9B0-4886-8BA4-C8A8AAC28012}";
                public const string Icon = "{8759AF9D-413B-4DCB-BD07-718C0F4B5923}";
            }
        }

        public readonly struct Trainer
        {
            public const string Id = "{61F4EFCF-B735-43F2-990D-F740FEEB2862}";
            public readonly struct Fields
            {
                public const string Name = "{3CAB073D-6514-4A41-B113-EA1B08A0686C}";
                public const string Thumbnail = "{7CB95D82-9392-4432-B341-A2A7BDBE8A19}";
            }
        }

        public readonly struct SocialLink
        {
            public const string Id = "{B9D47AAE-E975-4BB3-8706-7DCCC8EEEC2A}";
            public readonly struct Fields
            {
                public const string Platform = "{52ED37A7-0309-47B7-9976-151B20012DCC}";
                public const string Url = "{EC69B7F4-0F67-4F4B-9902-94CCF7CF027F}";
                public const string Icon = "{524A74A4-C163-4B97-8664-126E6C82A477}";
            }
        }
    }
}