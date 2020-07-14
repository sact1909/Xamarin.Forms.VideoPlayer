using System;
using System.Collections.Generic;
using System.Text;

namespace ChillPlayer.Models
{
    
    public partial class YouTubeStramingData
    {
        public ResponseContext ResponseContext { get; set; }
        public PlayabilityStatus PlayabilityStatus { get; set; }
        public StreamingData StreamingData { get; set; }
        public PlaybackTracking PlaybackTracking { get; set; }
        public Captions Captions { get; set; }
        public VideoDetails VideoDetails { get; set; }
        public PlayerConfig PlayerConfig { get; set; }
        public Storyboards Storyboards { get; set; }
        public Microformat Microformat { get; set; }
        public string TrackingParams { get; set; }
        public Attestation Attestation { get; set; }
        public VideoQualityPromoSupportedRenderers VideoQualityPromoSupportedRenderers { get; set; }
        public List<Message> Messages { get; set; }
    }

    public partial class Attestation
    {
        public PlayerAttestationRenderer PlayerAttestationRenderer { get; set; }
    }

    public partial class PlayerAttestationRenderer
    {
        public string Challenge { get; set; }
        public BotguardData BotguardData { get; set; }
    }

    public partial class BotguardData
    {
        public string Program { get; set; }
        public string InterpreterUrl { get; set; }
    }

    public partial class Captions
    {
        public PlayerCaptionsRenderer PlayerCaptionsRenderer { get; set; }
        public PlayerCaptionsTracklistRenderer PlayerCaptionsTracklistRenderer { get; set; }
    }

    public partial class PlayerCaptionsRenderer
    {
        public Uri BaseUrl { get; set; }
        public string Visibility { get; set; }
    }

    public partial class PlayerCaptionsTracklistRenderer
    {
        public List<CaptionTrack> CaptionTracks { get; set; }
        public List<AudioTrack> AudioTracks { get; set; }
        public List<TranslationLanguage> TranslationLanguages { get; set; }
        public long DefaultAudioTrackIndex { get; set; }
    }

    public partial class AudioTrack
    {
        public List<long> CaptionTrackIndices { get; set; }
    }

    public partial class CaptionTrack
    {
        public Uri BaseUrl { get; set; }
        public Description Name { get; set; }
        public string VssId { get; set; }
        public string LanguageCode { get; set; }
        public string Kind { get; set; }
        public bool IsTranslatable { get; set; }
    }

    public partial class Description
    {
        public string SimpleText { get; set; }
    }

    public partial class TranslationLanguage
    {
        public string LanguageCode { get; set; }
        public Description LanguageName { get; set; }
    }

    public partial class Message
    {
        public MealbarPromoRenderer MealbarPromoRenderer { get; set; }
    }

    public partial class MealbarPromoRenderer
    {
        public IconClass Icon { get; set; }
        public List<MessageTitle> MessageTexts { get; set; }
        public Button ActionButton { get; set; }
        public Button DismissButton { get; set; }
        public string TriggerCondition { get; set; }
        public string Style { get; set; }
        public string TrackingParams { get; set; }
        public List<ImpressionEndpointElement> ImpressionEndpoints { get; set; }
        public bool IsVisible { get; set; }
        public MessageTitle MessageTitle { get; set; }
    }

    public partial class Button
    {
        public DismissButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class DismissButtonButtonRenderer
    {
        public string Style { get; set; }
        public string Size { get; set; }
        public MessageTitle Text { get; set; }
        public ImpressionEndpointElement ServiceEndpoint { get; set; }
        public Endpoint NavigationEndpoint { get; set; }
        public string TrackingParams { get; set; }
    }

    public partial class Endpoint
    {
        public string ClickTrackingParams { get; set; }
        public EndpointCommandMetadata CommandMetadata { get; set; }
        public UrlEndpoint UrlEndpoint { get; set; }
    }

    public partial class EndpointCommandMetadata
    {
        public PurpleWebCommandMetadata WebCommandMetadata { get; set; }
    }

    public partial class PurpleWebCommandMetadata
    {
        public Uri Url { get; set; }
        public long RootVe { get; set; }
    }

    public partial class UrlEndpoint
    {
        public Uri Url { get; set; }
        public string Target { get; set; }
    }

    public partial class ImpressionEndpointElement
    {
        public string ClickTrackingParams { get; set; }
        public ImpressionEndpointCommandMetadata CommandMetadata { get; set; }
        public FeedbackEndpoint FeedbackEndpoint { get; set; }
    }

    public partial class ImpressionEndpointCommandMetadata
    {
        public FluffyWebCommandMetadata WebCommandMetadata { get; set; }
    }

    public partial class FluffyWebCommandMetadata
    {
        public string Url { get; set; }
        public bool SendPost { get; set; }
        public string ApiUrl { get; set; }
    }

    public partial class FeedbackEndpoint
    {
        public string FeedbackToken { get; set; }
        public UiActions UiActions { get; set; }
    }

    public partial class UiActions
    {
        public bool HideEnclosingContainer { get; set; }
    }

    public partial class MessageTitle
    {
        public List<MessageTitleRun> Runs { get; set; }
    }

    public partial class MessageTitleRun
    {
        public string Text { get; set; }
    }

    public partial class IconClass
    {
        public List<ThumbnailElement> Thumbnails { get; set; }
    }

    public partial class ThumbnailElement
    {
        public Uri Url { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
    }

    public partial class Microformat
    {
        public PlayerMicroformatRenderer PlayerMicroformatRenderer { get; set; }
    }

    public partial class PlayerMicroformatRenderer
    {
        public IconClass Thumbnail { get; set; }
        public Embed Embed { get; set; }
        public Description Title { get; set; }
        public Description Description { get; set; }
        public long LengthSeconds { get; set; }
        public Uri OwnerProfileUrl { get; set; }
        public string ExternalChannelId { get; set; }
        public bool IsFamilySafe { get; set; }
        public List<string> AvailableCountries { get; set; }
        public bool IsUnlisted { get; set; }
        public bool HasYpcMetadata { get; set; }
        public long ViewCount { get; set; }
        public string Category { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string OwnerChannelName { get; set; }
        public LiveBroadcastDetails LiveBroadcastDetails { get; set; }
        public DateTimeOffset UploadDate { get; set; }
    }

    public partial class Embed
    {
        public Uri IframeUrl { get; set; }
        public Uri FlashUrl { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public Uri FlashSecureUrl { get; set; }
    }

    public partial class LiveBroadcastDetails
    {
        public bool IsLiveNow { get; set; }
        public DateTimeOffset StartTimestamp { get; set; }
        public DateTimeOffset EndTimestamp { get; set; }
    }

    public partial class PlayabilityStatus
    {
        public string Status { get; set; }
        public bool PlayableInEmbed { get; set; }
        public Miniplayer Miniplayer { get; set; }
        public string ContextParams { get; set; }
    }

    public partial class Miniplayer
    {
        public MiniplayerRenderer MiniplayerRenderer { get; set; }
    }

    public partial class MiniplayerRenderer
    {
        public string PlaybackMode { get; set; }
    }

    public partial class PlaybackTracking
    {
        public PtrackingUrlClass VideostatsPlaybackUrl { get; set; }
        public PtrackingUrlClass VideostatsDelayplayUrl { get; set; }
        public PtrackingUrlClass VideostatsWatchtimeUrl { get; set; }
        public PtrackingUrlClass PtrackingUrl { get; set; }
        public PtrackingUrlClass QoeUrl { get; set; }
        public AtrUrlClass SetAwesomeUrl { get; set; }
        public AtrUrlClass AtrUrl { get; set; }
    }

    public partial class AtrUrlClass
    {
        public Uri BaseUrl { get; set; }
        public long ElapsedMediaTimeSeconds { get; set; }
    }

    public partial class PtrackingUrlClass
    {
        public Uri BaseUrl { get; set; }
    }

    public partial class PlayerConfig
    {
        public AudioConfig AudioConfig { get; set; }
        public StreamSelectionConfig StreamSelectionConfig { get; set; }
        public DaiConfig DaiConfig { get; set; }
        public MediaCommonConfig MediaCommonConfig { get; set; }
        public WebPlayerConfig WebPlayerConfig { get; set; }
    }

    public partial class AudioConfig
    {
        public double LoudnessDb { get; set; }
        public double PerceptualLoudnessDb { get; set; }
        public bool EnablePerFormatLoudness { get; set; }
    }

    public partial class DaiConfig
    {
        public bool EnableServerStitchedDai { get; set; }
    }

    public partial class MediaCommonConfig
    {
        public DynamicReadaheadConfig DynamicReadaheadConfig { get; set; }
    }

    public partial class DynamicReadaheadConfig
    {
        public long MaxReadAheadMediaTimeMs { get; set; }
        public long MinReadAheadMediaTimeMs { get; set; }
        public long ReadAheadGrowthRateMs { get; set; }
    }

    public partial class StreamSelectionConfig
    {
        public long MaxBitrate { get; set; }
    }

    public partial class WebPlayerConfig
    {
        public WebPlayerActionsPorting WebPlayerActionsPorting { get; set; }
    }

    public partial class WebPlayerActionsPorting
    {
        public GetSharePanelCommand GetSharePanelCommand { get; set; }
        public SubscribeCommand SubscribeCommand { get; set; }
        public UnsubscribeCommand UnsubscribeCommand { get; set; }
        public AddToWatchLaterCommand AddToWatchLaterCommand { get; set; }
        public RemoveFromWatchLaterCommand RemoveFromWatchLaterCommand { get; set; }
    }

    public partial class AddToWatchLaterCommand
    {
        public string ClickTrackingParams { get; set; }
        public ImpressionEndpointCommandMetadata CommandMetadata { get; set; }
        public AddToWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }
    }

    public partial class AddToWatchLaterCommandPlaylistEditEndpoint
    {
        public string PlaylistId { get; set; }
        public List<PurpleAction> Actions { get; set; }
    }

    public partial class PurpleAction
    {
        public string AddedVideoId { get; set; }
        public string Action { get; set; }
    }

    public partial class GetSharePanelCommand
    {
        public string ClickTrackingParams { get; set; }
        public ImpressionEndpointCommandMetadata CommandMetadata { get; set; }
        public WebPlayerShareEntityServiceEndpoint WebPlayerShareEntityServiceEndpoint { get; set; }
    }

    public partial class WebPlayerShareEntityServiceEndpoint
    {
        public string SerializedShareEntity { get; set; }
    }

    public partial class RemoveFromWatchLaterCommand
    {
        public string ClickTrackingParams { get; set; }
        public ImpressionEndpointCommandMetadata CommandMetadata { get; set; }
        public RemoveFromWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }
    }

    public partial class RemoveFromWatchLaterCommandPlaylistEditEndpoint
    {
        public string PlaylistId { get; set; }
        public List<FluffyAction> Actions { get; set; }
    }

    public partial class FluffyAction
    {
        public string Action { get; set; }
        public string RemovedVideoId { get; set; }
    }

    public partial class SubscribeCommand
    {
        public string ClickTrackingParams { get; set; }
        public ImpressionEndpointCommandMetadata CommandMetadata { get; set; }
        public SubscribeEndpoint SubscribeEndpoint { get; set; }
    }

    public partial class SubscribeEndpoint
    {
        public List<string> ChannelIds { get; set; }
        public string Params { get; set; }
    }

    public partial class UnsubscribeCommand
    {
        public string ClickTrackingParams { get; set; }
        public ImpressionEndpointCommandMetadata CommandMetadata { get; set; }
        public SubscribeEndpoint UnsubscribeEndpoint { get; set; }
    }

    public partial class ResponseContext
    {
        public List<ServiceTrackingParam> ServiceTrackingParams { get; set; }
        public WebResponseContextExtensionData WebResponseContextExtensionData { get; set; }
    }

    public partial class ServiceTrackingParam
    {
        public string Service { get; set; }
        public List<Param> Params { get; set; }
    }

    public partial class Param
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public partial class WebResponseContextExtensionData
    {
        public bool HasDecorated { get; set; }
    }

    public partial class Storyboards
    {
        public PlayerStoryboardSpecRenderer PlayerStoryboardSpecRenderer { get; set; }
    }

    public partial class PlayerStoryboardSpecRenderer
    {
        public Uri Spec { get; set; }
    }

    public partial class StreamingData
    {
        public long ExpiresInSeconds { get; set; }
        public List<object> Formats { get; set; }
        public List<AdaptiveFormat> AdaptiveFormats { get; set; }
    }

    public partial class AdaptiveFormat
    {
        public long Itag { get; set; }
        public Uri Url { get; set; }
        public string MimeType { get; set; }
        public long Bitrate { get; set; }
        public long? Width { get; set; }
        public long? Height { get; set; }
        public Range InitRange { get; set; }
        public Range IndexRange { get; set; }
        public string LastModified { get; set; }
        public long ContentLength { get; set; }
        public string Quality { get; set; }
        public long? Fps { get; set; }
        public string QualityLabel { get; set; }
        public ProjectionType ProjectionType { get; set; }
        public long AverageBitrate { get; set; }
        public long ApproxDurationMs { get; set; }
        public ColorInfo ColorInfo { get; set; }
        public bool? HighReplication { get; set; }
        public string AudioQuality { get; set; }
        public long? AudioSampleRate { get; set; }
        public long? AudioChannels { get; set; }
    }

    public partial class ColorInfo
    {
        public string Primaries { get; set; }
        public string TransferCharacteristics { get; set; }
        public string MatrixCoefficients { get; set; }
    }

    public partial class Range
    {
        public long Start { get; set; }
        public long End { get; set; }
    }

    public partial class VideoDetails
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public long LengthSeconds { get; set; }
        public string ChannelId { get; set; }
        public bool IsOwnerViewing { get; set; }
        public string ShortDescription { get; set; }
        public bool IsCrawlable { get; set; }
        public IconClass Thumbnail { get; set; }
        public long AverageRating { get; set; }
        public bool AllowRatings { get; set; }
        public long ViewCount { get; set; }
        public string Author { get; set; }
        public bool IsLowLatencyLiveStream { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsUnpluggedCorpus { get; set; }
        public string LatencyClass { get; set; }
        public bool IsLiveContent { get; set; }
    }

    public partial class VideoQualityPromoSupportedRenderers
    {
        public VideoQualityPromoRenderer VideoQualityPromoRenderer { get; set; }
    }

    public partial class VideoQualityPromoRenderer
    {
        public TriggerCriteria TriggerCriteria { get; set; }
        public Text Text { get; set; }
        public Endpoint Endpoint { get; set; }
        public string TrackingParams { get; set; }
        public Snackbar Snackbar { get; set; }
    }

    public partial class Snackbar
    {
        public NotificationActionRenderer NotificationActionRenderer { get; set; }
    }

    public partial class NotificationActionRenderer
    {
        public MessageTitle ResponseText { get; set; }
        public ActionButton ActionButton { get; set; }
        public string TrackingParams { get; set; }
    }

    public partial class ActionButton
    {
        public PurpleButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class PurpleButtonRenderer
    {
        public MessageTitle Text { get; set; }
        public Endpoint NavigationEndpoint { get; set; }
        public string TrackingParams { get; set; }
    }

    public partial class Text
    {
        public List<PurpleRun> Runs { get; set; }
    }

    public partial class PurpleRun
    {
        public string Text { get; set; }
        public bool? Bold { get; set; }
    }

    public partial class TriggerCriteria
    {
        public List<string> ConnectionWhitelists { get; set; }
        public long JoinLatencySeconds { get; set; }
        public long RebufferTimeSeconds { get; set; }
        public long WatchTimeWindowSeconds { get; set; }
        public long RefractorySeconds { get; set; }
    }

    public enum ProjectionType { Rectangular };
}
