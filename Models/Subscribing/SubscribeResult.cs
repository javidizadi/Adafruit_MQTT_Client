﻿using MQTTnet.Client.Subscribing;

using System.Collections.Generic;


namespace Adafruit.MQTT.Client.Models.Subscribing
{
    public class SubscribeResult
    {
        public List<SubscribeResultItem> SubscribeResults { get; }

        public SubscribeResult(MqttClientSubscribeResult result)
        {
            SubscribeResults = new List<SubscribeResultItem>();

            foreach (var item in result.Items)
            {
                SubscribeResults.Add(new SubscribeResultItem(item));
            }
        }
    }

}
