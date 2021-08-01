using System.Collections.Generic;

namespace Discord
{
    /// <summary>
    ///     Represents a discord sticker.
    /// </summary>
    public interface ISticker
    {
        /// <summary>
        ///     Gets the ID of this sticker.
        /// </summary>
        /// <returns>
        ///     A snowflake ID associated with this sticker.
        /// </returns>
        ulong Id { get; }
        /// <summary>
        ///     Gets the ID of the pack of this sticker.
        /// </summary>
        /// <returns>
        ///     A snowflake ID associated with the pack of this sticker.
        /// </returns>
        ulong? PackId { get; }
        /// <summary>
        ///     Gets the name of this sticker.
        /// </summary>
        /// <returns>
        ///     A <see langword="string"/> with the name of this sticker.
        /// </returns>
        string Name { get; }
        /// <summary>
        ///     Gets the description of this sticker.
        /// </summary>
        /// <returns>
        ///     A <see langword="string"/> with the description of this sticker.
        /// </returns>
        string Description { get; }
        /// <summary>
        ///     Gets the list of tags of this sticker.
        /// </summary>
        /// <returns>
        ///     A read-only list with the tags of this sticker.
        /// </returns>
        IReadOnlyCollection<string> Tags { get; }
        /// <summary>
        ///     Gets the asset hash of this sticker.
        /// </summary>
        /// <returns>
        ///     A <see langword="string"/> with the asset hash of this sticker.
        /// </returns>
        string Asset { get; }
        /// <summary>
        ///     Gets the type of sticker.
        /// </summary>
        /// <returns>
        ///     A <see cref="StickerType"/> with the type of this sticker.
        /// </returns>
        StickerType Type { get; }
        /// <summary>
        ///     Gets the format type of this sticker.
        /// </summary>
        /// <returns>
        ///     A <see cref="StickerFormatType"/> with the format type of this sticker.
        /// </returns>
        StickerFormatType FormatType { get; }
        /// <summary>
        ///     Gets whether this guild sticker can be used, may be false due to loss of Server Boosts
        /// </summary>
        /// <returns>
        ///     A <see langword="bool"/> with the avaibility of this sticker 
        /// </returns>
        bool? Available { get; }
        /// <summary>
        ///     Gets the id of the guild that owns this sticker
        /// </summary>
        /// <returns>
        ///     A <see cref="ISnowflakeEntity"/> with the id of the guild that owns this sticker
        /// </returns>
        ulong? GuildId { get; }
        /// <summary>
        ///     Gets the user that uploaded this guild sticker
        /// </summary>
        /// <returns>
        ///     A <see cref="IUser"/> with the user that uploaded the guild sticker
        /// </returns>
        public IUser User { get; }
        /// <summary>
        ///     Gets the sticker's sort order within its pack
        /// </summary>
        /// <returns>
        ///     A <see langword="int"/> that represents this sticker's sort order within its pack
        /// </returns>
        int? SortValue { get; }


    }
}
