﻿namespace DownKyi.Core.Settings.Models
{
    /// <summary>
    /// 基本
    /// </summary>
    public class BasicSettings
    {
        public AfterDownloadOperation AfterDownload { get; set; } = AfterDownloadOperation.NOT_SET;
        public AllowStatus IsListenClipboard { get; set; } = AllowStatus.NONE;
        public AllowStatus IsAutoParseVideo { get; set; } = AllowStatus.NONE;
        public ParseScope ParseScope { get; set; } = ParseScope.NOT_SET;
        public DownloadFinishedSort DownloadFinishedSort { get; set; } = DownloadFinishedSort.NOT_SET;
    }
}
