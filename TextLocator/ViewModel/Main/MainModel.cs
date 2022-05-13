﻿using System.Windows;

namespace TextLocator.ViewModel.Main
{
    /// <summary>
    /// 主窗口数据Model
    /// </summary>
    public class MainModel
    {
        // ================================ 分页
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 结果总条数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 预览分页
        /// </summary>
        public string PreviewPage { get; set; }
        /// <summary>
        /// 切换预览显示状态
        /// </summary>
        public Visibility PreviewSwitchVisibility { get; set; }

        // ================================ 工作状态
        /// <summary>
        /// 工作状态
        /// </summary>
        public string WorkStatus { get; set; }

        /// <summary>
        /// 工作进度
        /// </summary>
        public double WorkProgress { get; set; }

        // ================================ 任务栏图标
        /// <summary>
        /// 任务栏图标状态
        /// </summary>
        public System.Windows.Shell.TaskbarItemProgressState ProgressState { get; set; }

        /// <summary>
        /// 任务栏进度
        /// </summary>
        public double ProgressValue { get; set; }
    }
}
