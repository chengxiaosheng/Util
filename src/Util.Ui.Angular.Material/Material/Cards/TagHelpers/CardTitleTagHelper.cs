﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Angular.Base;
using Util.Ui.Configs;
using Util.Ui.Material.Cards.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Cards.TagHelpers {
    /// <summary>
    /// 卡片标题
    /// </summary>
    [HtmlTargetElement( "util-card-title" )]
    public class CardTitleTagHelper : AngularTagHelperBase {
        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new CardTitleRender( new Config( context ) );
        }
    }
}