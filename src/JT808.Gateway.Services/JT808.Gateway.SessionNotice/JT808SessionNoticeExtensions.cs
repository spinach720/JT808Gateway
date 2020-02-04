﻿
using JT808.Gateway.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Gateway.SessionNotice
{
    public static class JT808SessionNoticeExtensions
    {
        /// <summary>
        /// 会话通知服务（不同的消费者实例）
        /// </summary>
        /// <param name="jT808ClientBuilder"></param>
        /// <returns></returns>
        public static IJT808ClientBuilder AddSessionNotice(this IJT808ClientBuilder jT808ClientBuilder)
        {
            jT808ClientBuilder.JT808Builder.Services.AddSingleton<JT808SessionNoticeService>();
            jT808ClientBuilder.JT808Builder.Services.AddHostedService<JT808SessionNoticeHostedService>();
            return jT808ClientBuilder;
        }

        /// <summary>
        /// 消息会话通知服务（不同的消费者实例）
        /// </summary>
        /// <typeparam name="TSessionNoticeService">自定义会话通知服务</typeparam>
        /// <param name="jT808ClientBuilder"></param>
        /// <returns></returns>
        public static IJT808ClientBuilder AddSessionNotice<TSessionNoticeService>(this IJT808ClientBuilder jT808ClientBuilder)
           where TSessionNoticeService : JT808SessionNoticeService
        {
            jT808ClientBuilder.JT808Builder.Services.AddSingleton<JT808SessionNoticeService,TSessionNoticeService>();
            jT808ClientBuilder.JT808Builder.Services.AddHostedService<JT808SessionNoticeHostedService>();
            return jT808ClientBuilder;
        }

        /// <summary>
        /// 会话通知服务（不同的消费者实例）
        /// </summary>
        /// <param name="jT808NormalGatewayBuilder"></param>
        /// <returns></returns>
        public static IJT808NormalGatewayBuilder AddSessionNotice(this IJT808NormalGatewayBuilder  jT808NormalGatewayBuilder)
        {
            jT808NormalGatewayBuilder.JT808Builder.Services.AddSingleton<JT808SessionNoticeService>();
            jT808NormalGatewayBuilder.JT808Builder.Services.AddHostedService<JT808SessionNoticeHostedService>();
            return jT808NormalGatewayBuilder;
        }

        /// <summary>
        /// 消息会话通知服务（不同的消费者实例）
        /// </summary>
        /// <typeparam name="TSessionNoticeService">自定义会话通知服务</typeparam>
        /// <param name="jT808NormalGatewayBuilder"></param>
        /// <returns></returns>
        public static IJT808NormalGatewayBuilder AddSessionNotice<TSessionNoticeService>(this IJT808NormalGatewayBuilder jT808NormalGatewayBuilder)
           where TSessionNoticeService : JT808SessionNoticeService
        {
            jT808NormalGatewayBuilder.JT808Builder.Services.AddSingleton<JT808SessionNoticeService, TSessionNoticeService>();
            jT808NormalGatewayBuilder.JT808Builder.Services.AddHostedService<JT808SessionNoticeHostedService>();
            return jT808NormalGatewayBuilder;
        }
    }
}
