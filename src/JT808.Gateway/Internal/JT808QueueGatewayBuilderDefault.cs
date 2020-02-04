﻿using JT808.Gateway.Abstractions;
using JT808.Protocol;

namespace JT808.Gateway.Internal
{
    public class JT808QueueGatewayBuilderDefault : IJT808QueueGatewayBuilder
    {
        public IJT808Builder JT808Builder { get; }

        public JT808QueueGatewayBuilderDefault(IJT808Builder builder)
        {
            JT808Builder = builder;
        }

        public IJT808Builder Builder()
        {
            return JT808Builder;
        }
    }
}