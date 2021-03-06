﻿using Newtonsoft.Json;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a Telegram user or bot.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class User : IConversation
    {
        /// <summary>
        /// Unique identifier for this user or bot
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public int Id { get; set; }

        /// <summary>
        /// User‘s or bot’s first name
        /// </summary>
        [JsonProperty(PropertyName = "first_name", Required = Required.Always)]
        public string FirstName;

        /// <summary>
        /// Optional. User‘s or bot’s last name
        /// </summary>
        [JsonProperty(PropertyName = "last_name", Required = Required.Default)]
        public string LastName;

        /// <summary>
        /// Optional. User‘s or bot’s username
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.Default)]
        public string Username;
    }
}
