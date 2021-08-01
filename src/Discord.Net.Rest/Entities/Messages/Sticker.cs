using System.Collections.Generic;
using System.Diagnostics;
using Model = Discord.API.Sticker;

namespace Discord
{
    /// <inheritdoc cref="ISticker"/>
    [DebuggerDisplay(@"{DebuggerDisplay,nq}")]
    public class Sticker : ISticker
    {
        /// <inheritdoc />
        public ulong Id { get; }
        /// <inheritdoc />
        public ulong? PackId { get; }
        /// <inheritdoc />
        public string Name { get; }
        /// <inheritdoc />
        public string Description { get; }
        /// <inheritdoc />
        public IReadOnlyCollection<string> Tags { get; }
        /// <inheritdoc />
        public string Asset { get; }
        /// <inheritdoc />
        public StickerType Type { get; }
        /// <inheritdoc />
        public StickerFormatType FormatType { get; }
        /// <inheritdoc />
        public bool? Available { get; }
        /// <inheritdoc />
        public ulong? GuildId { get; }
        /// <inheritdoc />
        public IUser User { get; }
        /// <inheritdoc />
        public int? SortValue { get; }

        internal Sticker(ulong id, ulong? packId, string name, string description, string[] tags, string asset, StickerType type, StickerFormatType formatType, bool? available, ulong? guildId, IUser user, int? sortValue)
        {
            Id = id;
            PackId = packId;
            Name = name;
            Description = description;
            Tags = tags.ToReadOnlyCollection();
            Asset = asset;
            Type = type;
            FormatType = formatType;
            Available = available;
            GuildId = guildId;
            User = user;
            SortValue = sortValue;
        }
        internal static Sticker Create(Model model)
        {
            return new Sticker(model.Id, model.PackId.ToNullable() , model.Name, model.Desription,
                model.Tags.IsSpecified ? model.Tags.Value.Split(',') : new string[0],
                model.Asset, model.Type, model.FormatType, model.Available.ToNullable(), model.GuildId.ToNullable(), model.User.IsSpecified ? (IUser)model.User.Value : null, model.SortValue.ToNullable());
        }

        private string DebuggerDisplay => $"{Name} ({Id})";
    }
}
