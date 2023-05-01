﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;


[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]

namespace JDFixer
{
    internal class PluginConfig
    {
        public static PluginConfig Instance { get; set; }

        public virtual bool enabled { get; set; } = false;

        
        public float jumpDistance { get; set; } = 24f;
        public virtual int minJumpDistance { get; set; } = 12;
        public virtual int maxJumpDistance { get; set; } = 35;
        public virtual bool use_jd_pref { get; set; } = false;

        [UseConverter(typeof(ListConverter<JDPref>))]
        [NonNullable]
        public virtual List<JDPref> preferredValues { get; set; } = new List<JDPref>();


        public float reactionTime { get; set; } = 500f;
        public virtual int minReactionTime { get; set; } = 300;
        public virtual int maxReactionTime { get; set; } = 1600;
        public virtual bool use_rt_pref { get; set; } = false;

        [UseConverter(typeof(ListConverter<RTPref>))]
        [NonNullable]
        public virtual List<RTPref> rt_preferredValues { get; set; } = new List<RTPref>();


        //1.19.1 Feature update
        public virtual int slider_setting { get; set; } = 0;
        public virtual int pref_selected { get; set; } = 0;

        public virtual int use_heuristic { get; set; } = 0;
        public float lower_threshold { get; set; } = 1f;
        public float upper_threshold { get; set; } = 100f;

        public virtual bool rt_display_enabled { get; set; } = true;
        public virtual bool legacy_display_enabled { get; set; } = false;

        //1.26.0 Feature update
        public virtual bool use_offset { get; set; } = false;
        public virtual float offset_fraction { get; set; } = 8f;

        // 1.29.1
        public virtual int song_speed_setting { get; set; } = 0;

        public bool af_enabled { get; set; } = false;


        /// <summary>
        /// Call this to force BSIPA to update the config file. This is also called by BSIPA if it detects the file was modified.
        /// </summary>
        public virtual void Changed()
        {
            // Do stuff when the config is changed.
        }

        /// <summary>
        /// Call this to have BSIPA copy the values from <paramref name="other"/> into this config.
        /// </summary>
        public virtual void CopyFrom(PluginConfig other)
        {
            // This instance's members populated from other
        }
    }

    public class JDPref
    {
        public float njs = 16f;
        public float jumpDistance = 18f;

        public JDPref()
        {

        }

        public JDPref(float njs, float jumpDistance)
        {
            this.njs = njs;
            this.jumpDistance = jumpDistance;
        }
    }

    // Reaction Time Mode
    public class RTPref
    {
        public float njs = 16f;
        public float reactionTime = 800f;

        public RTPref()
        {

        }

        public RTPref(float njs, float reactionTime)
        {
            this.njs = njs;
            this.reactionTime = reactionTime;
        }
    }
}
