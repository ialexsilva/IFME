﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ifme
{
    public class MediaQueue
    {
        public bool Enable { get; set; }
		public string File { get; set; }
        public TargetFormat OutputFormat { get; set; }
        public List<MediaQueueAudio> Audio { get; set; } = new List<MediaQueueAudio>();
        public List<MediaQueueVideo> Video { get; set; } = new List<MediaQueueVideo>();
        public List<MediaQueueSubtitle> Subtitle { get; set; } = new List<MediaQueueSubtitle>();
        public List<MediaQueueAttachment> Attachment { get; set; } = new List<MediaQueueAttachment>();
		public FFmpegDotNet.FFmpeg.Stream MediaInfo { get; set; }
    }
}
