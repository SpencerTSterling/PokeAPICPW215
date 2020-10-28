﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokeAPICore
{

    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_main_series { get; set; }
        public Generation generation { get; set; }
        public Name[] names { get; set; }
        public Effect_Entries[] effect_entries { get; set; }
        public Effect_Changes[] effect_changes { get; set; }
        public Flavor_Text_Entries[] flavor_text_entries { get; set; }
        public Pokemon[] pokemon { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public string name { get; set; }
        public Language language { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Effect_Entries
    {
        public string effect { get; set; }
        public string short_effect { get; set; }
        public Language1 language { get; set; }
    }

    public class Language1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Effect_Changes
    {
        public Version_Group version_group { get; set; }
        public Effect_Entries1[] effect_entries { get; set; }
    }

    public class Version_Group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Effect_Entries1
    {
        public string effect { get; set; }
        public Language2 language { get; set; }
    }

    public class Language2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Flavor_Text_Entries
    {
        public string flavor_text { get; set; }
        public Language3 language { get; set; }
        public Version_Group1 version_group { get; set; }
    }

    public class Language3
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Pokemon
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Pokemon1 pokemon { get; set; }
    }

    public class Pokemon1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
