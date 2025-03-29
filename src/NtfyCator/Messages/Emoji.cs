// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Runtime.Serialization;

/// <summary>
/// Emojis supported by ntfy.
/// </summary>
public enum Emoji
{
    /// <summary>
    /// 😀
    /// </summary>
    [EnumMember(Value = "grinning")]
    Grinning,

    /// <summary>
    /// 😃
    /// </summary>
    [EnumMember(Value = "smiley")]
    Smiley,

    /// <summary>
    /// 😄
    /// </summary>
    [EnumMember(Value = "smile")]
    Smile,

    /// <summary>
    /// 😁
    /// </summary>
    [EnumMember(Value = "grin")]
    Grin,

    /// <summary>
    /// 😆
    /// </summary>
    [EnumMember(Value = "laughing")]
    Laughing,

    /// <summary>
    /// 😅
    /// </summary>
    [EnumMember(Value = "sweat_smile")]
    SweatSmile,

    /// <summary>
    /// 🤣
    /// </summary>
    [EnumMember(Value = "rofl")]
    Rofl,

    /// <summary>
    /// 😂
    /// </summary>
    [EnumMember(Value = "joy")]
    Joy,

    /// <summary>
    /// 🙂
    /// </summary>
    [EnumMember(Value = "slightly_smiling_face")]
    SlightlySmilingFace,

    /// <summary>
    /// 🙃
    /// </summary>
    [EnumMember(Value = "upside_down_face")]
    UpsideDownFace,

    /// <summary>
    /// 😉
    /// </summary>
    [EnumMember(Value = "wink")]
    Wink,

    /// <summary>
    /// 😊
    /// </summary>
    [EnumMember(Value = "blush")]
    Blush,

    /// <summary>
    /// 😇
    /// </summary>
    [EnumMember(Value = "innocent")]
    Innocent,

    /// <summary>
    /// 🥰
    /// </summary>
    [EnumMember(Value = "smiling_face_with_three_hearts")]
    SmilingFaceWithThreeHearts,

    /// <summary>
    /// 😍
    /// </summary>
    [EnumMember(Value = "heart_eyes")]
    HeartEyes,

    /// <summary>
    /// 🤩
    /// </summary>
    [EnumMember(Value = "star_struck")]
    StarStruck,

    /// <summary>
    /// 😘
    /// </summary>
    [EnumMember(Value = "kissing_heart")]
    KissingHeart,

    /// <summary>
    /// 😗
    /// </summary>
    [EnumMember(Value = "kissing")]
    Kissing,

    /// <summary>
    /// ☺️
    /// </summary>
    [EnumMember(Value = "relaxed")]
    Relaxed,

    /// <summary>
    /// 😚
    /// </summary>
    [EnumMember(Value = "kissing_closed_eyes")]
    KissingClosedEyes,

    /// <summary>
    /// 😙
    /// </summary>
    [EnumMember(Value = "kissing_smiling_eyes")]
    KissingSmilingEyes,

    /// <summary>
    /// 🥲
    /// </summary>
    [EnumMember(Value = "smiling_face_with_tear")]
    SmilingFaceWithTear,

    /// <summary>
    /// 😋
    /// </summary>
    [EnumMember(Value = "yum")]
    Yum,

    /// <summary>
    /// 😛
    /// </summary>
    [EnumMember(Value = "stuck_out_tongue")]
    StuckOutTongue,

    /// <summary>
    /// 😜
    /// </summary>
    [EnumMember(Value = "stuck_out_tongue_winking_eye")]
    StuckOutTongueWinkingEye,

    /// <summary>
    /// 🤪
    /// </summary>
    [EnumMember(Value = "zany_face")]
    ZanyFace,

    /// <summary>
    /// 😝
    /// </summary>
    [EnumMember(Value = "stuck_out_tongue_closed_eyes")]
    StuckOutTongueClosedEyes,

    /// <summary>
    /// 🤑
    /// </summary>
    [EnumMember(Value = "money_mouth_face")]
    MoneyMouthFace,

    /// <summary>
    /// 🤗
    /// </summary>
    [EnumMember(Value = "hugs")]
    Hugs,

    /// <summary>
    /// 🤭
    /// </summary>
    [EnumMember(Value = "hand_over_mouth")]
    HandOverMouth,

    /// <summary>
    /// 🤫
    /// </summary>
    [EnumMember(Value = "shushing_face")]
    ShushingFace,

    /// <summary>
    /// 🤔
    /// </summary>
    [EnumMember(Value = "thinking")]
    Thinking,

    /// <summary>
    /// 🤐
    /// </summary>
    [EnumMember(Value = "zipper_mouth_face")]
    ZipperMouthFace,

    /// <summary>
    /// 🤨
    /// </summary>
    [EnumMember(Value = "raised_eyebrow")]
    RaisedEyebrow,

    /// <summary>
    /// 😐
    /// </summary>
    [EnumMember(Value = "neutral_face")]
    NeutralFace,

    /// <summary>
    /// 😑
    /// </summary>
    [EnumMember(Value = "expressionless")]
    Expressionless,

    /// <summary>
    /// 😶
    /// </summary>
    [EnumMember(Value = "no_mouth")]
    NoMouth,

    /// <summary>
    /// 😶‍🌫️
    /// </summary>
    [EnumMember(Value = "face_in_clouds")]
    FaceInClouds,

    /// <summary>
    /// 😏
    /// </summary>
    [EnumMember(Value = "smirk")]
    Smirk,

    /// <summary>
    /// 😒
    /// </summary>
    [EnumMember(Value = "unamused")]
    Unamused,

    /// <summary>
    /// 🙄
    /// </summary>
    [EnumMember(Value = "roll_eyes")]
    RollEyes,

    /// <summary>
    /// 😬
    /// </summary>
    [EnumMember(Value = "grimacing")]
    Grimacing,

    /// <summary>
    /// 😮‍💨
    /// </summary>
    [EnumMember(Value = "face_exhaling")]
    FaceExhaling,

    /// <summary>
    /// 🤥
    /// </summary>
    [EnumMember(Value = "lying_face")]
    LyingFace,

    /// <summary>
    /// 😌
    /// </summary>
    [EnumMember(Value = "relieved")]
    Relieved,

    /// <summary>
    /// 😔
    /// </summary>
    [EnumMember(Value = "pensive")]
    Pensive,

    /// <summary>
    /// 😪
    /// </summary>
    [EnumMember(Value = "sleepy")]
    Sleepy,

    /// <summary>
    /// 🤤
    /// </summary>
    [EnumMember(Value = "drooling_face")]
    DroolingFace,

    /// <summary>
    /// 😴
    /// </summary>
    [EnumMember(Value = "sleeping")]
    Sleeping,

    /// <summary>
    /// 😷
    /// </summary>
    [EnumMember(Value = "mask")]
    Mask,

    /// <summary>
    /// 🤒
    /// </summary>
    [EnumMember(Value = "face_with_thermometer")]
    FaceWithThermometer,

    /// <summary>
    /// 🤕
    /// </summary>
    [EnumMember(Value = "face_with_head_bandage")]
    FaceWithHeadBandage,

    /// <summary>
    /// 🤢
    /// </summary>
    [EnumMember(Value = "nauseated_face")]
    NauseatedFace,

    /// <summary>
    /// 🤮
    /// </summary>
    [EnumMember(Value = "vomiting_face")]
    VomitingFace,

    /// <summary>
    /// 🤧
    /// </summary>
    [EnumMember(Value = "sneezing_face")]
    SneezingFace,

    /// <summary>
    /// 🥵
    /// </summary>
    [EnumMember(Value = "hot_face")]
    HotFace,

    /// <summary>
    /// 🥶
    /// </summary>
    [EnumMember(Value = "cold_face")]
    ColdFace,

    /// <summary>
    /// 🥴
    /// </summary>
    [EnumMember(Value = "woozy_face")]
    WoozyFace,

    /// <summary>
    /// 😵
    /// </summary>
    [EnumMember(Value = "dizzy_face")]
    DizzyFace,

    /// <summary>
    /// 😵‍💫
    /// </summary>
    [EnumMember(Value = "face_with_spiral_eyes")]
    FaceWithSpiralEyes,

    /// <summary>
    /// 🤯
    /// </summary>
    [EnumMember(Value = "exploding_head")]
    ExplodingHead,

    /// <summary>
    /// 🤠
    /// </summary>
    [EnumMember(Value = "cowboy_hat_face")]
    CowboyHatFace,

    /// <summary>
    /// 🥳
    /// </summary>
    [EnumMember(Value = "partying_face")]
    PartyingFace,

    /// <summary>
    /// 🥸
    /// </summary>
    [EnumMember(Value = "disguised_face")]
    DisguisedFace,

    /// <summary>
    /// 😎
    /// </summary>
    [EnumMember(Value = "sunglasses")]
    Sunglasses,

    /// <summary>
    /// 🤓
    /// </summary>
    [EnumMember(Value = "nerd_face")]
    NerdFace,

    /// <summary>
    /// 🧐
    /// </summary>
    [EnumMember(Value = "monocle_face")]
    MonocleFace,

    /// <summary>
    /// 😕
    /// </summary>
    [EnumMember(Value = "confused")]
    Confused,

    /// <summary>
    /// 😟
    /// </summary>
    [EnumMember(Value = "worried")]
    Worried,

    /// <summary>
    /// 🙁
    /// </summary>
    [EnumMember(Value = "slightly_frowning_face")]
    SlightlyFrowningFace,

    /// <summary>
    /// ☹️
    /// </summary>
    [EnumMember(Value = "frowning_face")]
    FrowningFace,

    /// <summary>
    /// 😮
    /// </summary>
    [EnumMember(Value = "open_mouth")]
    OpenMouth,

    /// <summary>
    /// 😯
    /// </summary>
    [EnumMember(Value = "hushed")]
    Hushed,

    /// <summary>
    /// 😲
    /// </summary>
    [EnumMember(Value = "astonished")]
    Astonished,

    /// <summary>
    /// 😳
    /// </summary>
    [EnumMember(Value = "flushed")]
    Flushed,

    /// <summary>
    /// 🥺
    /// </summary>
    [EnumMember(Value = "pleading_face")]
    PleadingFace,

    /// <summary>
    /// 😦
    /// </summary>
    [EnumMember(Value = "frowning")]
    Frowning,

    /// <summary>
    /// 😧
    /// </summary>
    [EnumMember(Value = "anguished")]
    Anguished,

    /// <summary>
    /// 😨
    /// </summary>
    [EnumMember(Value = "fearful")]
    Fearful,

    /// <summary>
    /// 😰
    /// </summary>
    [EnumMember(Value = "cold_sweat")]
    ColdSweat,

    /// <summary>
    /// 😥
    /// </summary>
    [EnumMember(Value = "disappointed_relieved")]
    DisappointedRelieved,

    /// <summary>
    /// 😢
    /// </summary>
    [EnumMember(Value = "cry")]
    Cry,

    /// <summary>
    /// 😭
    /// </summary>
    [EnumMember(Value = "sob")]
    Sob,

    /// <summary>
    /// 😱
    /// </summary>
    [EnumMember(Value = "scream")]
    Scream,

    /// <summary>
    /// 😖
    /// </summary>
    [EnumMember(Value = "confounded")]
    Confounded,

    /// <summary>
    /// 😣
    /// </summary>
    [EnumMember(Value = "persevere")]
    Persevere,

    /// <summary>
    /// 😞
    /// </summary>
    [EnumMember(Value = "disappointed")]
    Disappointed,

    /// <summary>
    /// 😓
    /// </summary>
    [EnumMember(Value = "sweat")]
    Sweat,

    /// <summary>
    /// 😩
    /// </summary>
    [EnumMember(Value = "weary")]
    Weary,

    /// <summary>
    /// 😫
    /// </summary>
    [EnumMember(Value = "tired_face")]
    TiredFace,

    /// <summary>
    /// 🥱
    /// </summary>
    [EnumMember(Value = "yawning_face")]
    YawningFace,

    /// <summary>
    /// 😤
    /// </summary>
    [EnumMember(Value = "triumph")]
    Triumph,

    /// <summary>
    /// 😡
    /// </summary>
    [EnumMember(Value = "rage")]
    Rage,

    /// <summary>
    /// 😠
    /// </summary>
    [EnumMember(Value = "angry")]
    Angry,

    /// <summary>
    /// 🤬
    /// </summary>
    [EnumMember(Value = "cursing_face")]
    CursingFace,

    /// <summary>
    /// 😈
    /// </summary>
    [EnumMember(Value = "smiling_imp")]
    SmilingImp,

    /// <summary>
    /// 👿
    /// </summary>
    [EnumMember(Value = "imp")]
    Imp,

    /// <summary>
    /// 💀
    /// </summary>
    [EnumMember(Value = "skull")]
    Skull,

    /// <summary>
    /// ☠️
    /// </summary>
    [EnumMember(Value = "skull_and_crossbones")]
    SkullAndCrossbones,

    /// <summary>
    /// 💩
    /// </summary>
    [EnumMember(Value = "hankey")]
    Hankey,

    /// <summary>
    /// 🤡
    /// </summary>
    [EnumMember(Value = "clown_face")]
    ClownFace,

    /// <summary>
    /// 👹
    /// </summary>
    [EnumMember(Value = "japanese_ogre")]
    JapaneseOgre,

    /// <summary>
    /// 👺
    /// </summary>
    [EnumMember(Value = "japanese_goblin")]
    JapaneseGoblin,

    /// <summary>
    /// 👻
    /// </summary>
    [EnumMember(Value = "ghost")]
    Ghost,

    /// <summary>
    /// 👽
    /// </summary>
    [EnumMember(Value = "alien")]
    Alien,

    /// <summary>
    /// 👾
    /// </summary>
    [EnumMember(Value = "space_invader")]
    SpaceInvader,

    /// <summary>
    /// 🤖
    /// </summary>
    [EnumMember(Value = "robot")]
    Robot,

    /// <summary>
    /// 😺
    /// </summary>
    [EnumMember(Value = "smiley_cat")]
    SmileyCat,

    /// <summary>
    /// 😸
    /// </summary>
    [EnumMember(Value = "smile_cat")]
    SmileCat,

    /// <summary>
    /// 😹
    /// </summary>
    [EnumMember(Value = "joy_cat")]
    JoyCat,

    /// <summary>
    /// 😻
    /// </summary>
    [EnumMember(Value = "heart_eyes_cat")]
    HeartEyesCat,

    /// <summary>
    /// 😼
    /// </summary>
    [EnumMember(Value = "smirk_cat")]
    SmirkCat,

    /// <summary>
    /// 😽
    /// </summary>
    [EnumMember(Value = "kissing_cat")]
    KissingCat,

    /// <summary>
    /// 🙀
    /// </summary>
    [EnumMember(Value = "scream_cat")]
    ScreamCat,

    /// <summary>
    /// 😿
    /// </summary>
    [EnumMember(Value = "crying_cat_face")]
    CryingCatFace,

    /// <summary>
    /// 😾
    /// </summary>
    [EnumMember(Value = "pouting_cat")]
    PoutingCat,

    /// <summary>
    /// 🙈
    /// </summary>
    [EnumMember(Value = "see_no_evil")]
    SeeNoEvil,

    /// <summary>
    /// 🙉
    /// </summary>
    [EnumMember(Value = "hear_no_evil")]
    HearNoEvil,

    /// <summary>
    /// 🙊
    /// </summary>
    [EnumMember(Value = "speak_no_evil")]
    SpeakNoEvil,

    /// <summary>
    /// 💋
    /// </summary>
    [EnumMember(Value = "kiss")]
    Kiss,

    /// <summary>
    /// 💌
    /// </summary>
    [EnumMember(Value = "love_letter")]
    LoveLetter,

    /// <summary>
    /// 💘
    /// </summary>
    [EnumMember(Value = "cupid")]
    Cupid,

    /// <summary>
    /// 💝
    /// </summary>
    [EnumMember(Value = "gift_heart")]
    GiftHeart,

    /// <summary>
    /// 💖
    /// </summary>
    [EnumMember(Value = "sparkling_heart")]
    SparklingHeart,

    /// <summary>
    /// 💗
    /// </summary>
    [EnumMember(Value = "heartpulse")]
    Heartpulse,

    /// <summary>
    /// 💓
    /// </summary>
    [EnumMember(Value = "heartbeat")]
    Heartbeat,

    /// <summary>
    /// 💞
    /// </summary>
    [EnumMember(Value = "revolving_hearts")]
    RevolvingHearts,

    /// <summary>
    /// 💕
    /// </summary>
    [EnumMember(Value = "two_hearts")]
    TwoHearts,

    /// <summary>
    /// 💟
    /// </summary>
    [EnumMember(Value = "heart_decoration")]
    HeartDecoration,

    /// <summary>
    /// ❣️
    /// </summary>
    [EnumMember(Value = "heavy_heart_exclamation")]
    HeavyHeartExclamation,

    /// <summary>
    /// 💔
    /// </summary>
    [EnumMember(Value = "broken_heart")]
    BrokenHeart,

    /// <summary>
    /// ❤️‍🔥
    /// </summary>
    [EnumMember(Value = "heart_on_fire")]
    HeartOnFire,

    /// <summary>
    /// ❤️‍🩹
    /// </summary>
    [EnumMember(Value = "mending_heart")]
    MendingHeart,

    /// <summary>
    /// ❤️
    /// </summary>
    [EnumMember(Value = "heart")]
    Heart,

    /// <summary>
    /// 🧡
    /// </summary>
    [EnumMember(Value = "orange_heart")]
    OrangeHeart,

    /// <summary>
    /// 💛
    /// </summary>
    [EnumMember(Value = "yellow_heart")]
    YellowHeart,

    /// <summary>
    /// 💚
    /// </summary>
    [EnumMember(Value = "green_heart")]
    GreenHeart,

    /// <summary>
    /// 💙
    /// </summary>
    [EnumMember(Value = "blue_heart")]
    BlueHeart,

    /// <summary>
    /// 💜
    /// </summary>
    [EnumMember(Value = "purple_heart")]
    PurpleHeart,

    /// <summary>
    /// 🤎
    /// </summary>
    [EnumMember(Value = "brown_heart")]
    BrownHeart,

    /// <summary>
    /// 🖤
    /// </summary>
    [EnumMember(Value = "black_heart")]
    BlackHeart,

    /// <summary>
    /// 🤍
    /// </summary>
    [EnumMember(Value = "white_heart")]
    WhiteHeart,

    /// <summary>
    /// 💯
    /// </summary>
    [EnumMember(Value = "100")]
    OneHundred,

    /// <summary>
    /// 💢
    /// </summary>
    [EnumMember(Value = "anger")]
    Anger,

    /// <summary>
    /// 💥
    /// </summary>
    [EnumMember(Value = "boom")]
    Boom,

    /// <summary>
    /// 💫
    /// </summary>
    [EnumMember(Value = "dizzy")]
    Dizzy,

    /// <summary>
    /// 💦
    /// </summary>
    [EnumMember(Value = "sweat_drops")]
    SweatDrops,

    /// <summary>
    /// 💨
    /// </summary>
    [EnumMember(Value = "dash")]
    Dash,

    /// <summary>
    /// 🕳️
    /// </summary>
    [EnumMember(Value = "hole")]
    Hole,

    /// <summary>
    /// 💣
    /// </summary>
    [EnumMember(Value = "bomb")]
    Bomb,

    /// <summary>
    /// 💬
    /// </summary>
    [EnumMember(Value = "speech_balloon")]
    SpeechBalloon,

    /// <summary>
    /// 👁️‍🗨️
    /// </summary>
    [EnumMember(Value = "eye_speech_bubble")]
    EyeSpeechBubble,

    /// <summary>
    /// 🗨️
    /// </summary>
    [EnumMember(Value = "left_speech_bubble")]
    LeftSpeechBubble,

    /// <summary>
    /// 🗯️
    /// </summary>
    [EnumMember(Value = "right_anger_bubble")]
    RightAngerBubble,

    /// <summary>
    /// 💭
    /// </summary>
    [EnumMember(Value = "thought_balloon")]
    ThoughtBalloon,

    /// <summary>
    /// 💤
    /// </summary>
    [EnumMember(Value = "zzz")]
    Zzz,

    /// <summary>
    /// 👋
    /// </summary>
    [EnumMember(Value = "wave")]
    Wave,

    /// <summary>
    /// 🤚
    /// </summary>
    [EnumMember(Value = "raised_back_of_hand")]
    RaisedBackOfHand,

    /// <summary>
    /// 🖐️
    /// </summary>
    [EnumMember(Value = "raised_hand_with_fingers_splayed")]
    RaisedHandWithFingersSplayed,

    /// <summary>
    /// ✋
    /// </summary>
    [EnumMember(Value = "hand")]
    Hand,

    /// <summary>
    /// 🖖
    /// </summary>
    [EnumMember(Value = "vulcan_salute")]
    VulcanSalute,

    /// <summary>
    /// 👌
    /// </summary>
    [EnumMember(Value = "ok_hand")]
    OkHand,

    /// <summary>
    /// 🤌
    /// </summary>
    [EnumMember(Value = "pinched_fingers")]
    PinchedFingers,

    /// <summary>
    /// 🤏
    /// </summary>
    [EnumMember(Value = "pinching_hand")]
    PinchingHand,

    /// <summary>
    /// ✌️
    /// </summary>
    [EnumMember(Value = "v")]
    V,

    /// <summary>
    /// 🤞
    /// </summary>
    [EnumMember(Value = "crossed_fingers")]
    CrossedFingers,

    /// <summary>
    /// 🤟
    /// </summary>
    [EnumMember(Value = "love_you_gesture")]
    LoveYouGesture,

    /// <summary>
    /// 🤘
    /// </summary>
    [EnumMember(Value = "metal")]
    Metal,

    /// <summary>
    /// 🤙
    /// </summary>
    [EnumMember(Value = "call_me_hand")]
    CallMeHand,

    /// <summary>
    /// 👈
    /// </summary>
    [EnumMember(Value = "point_left")]
    PointLeft,

    /// <summary>
    /// 👉
    /// </summary>
    [EnumMember(Value = "point_right")]
    PointRight,

    /// <summary>
    /// 👆
    /// </summary>
    [EnumMember(Value = "point_up_2")]
    PointUp2,

    /// <summary>
    /// 🖕
    /// </summary>
    [EnumMember(Value = "middle_finger")]
    MiddleFinger,

    /// <summary>
    /// 👇
    /// </summary>
    [EnumMember(Value = "point_down")]
    PointDown,

    /// <summary>
    /// ☝️
    /// </summary>
    [EnumMember(Value = "point_up")]
    PointUp,

    /// <summary>
    /// 👍
    /// </summary>
    [EnumMember(Value = "+1")]
    PlusOne,

    /// <summary>
    /// 👎
    /// </summary>
    [EnumMember(Value = "-1")]
    MinusOne,

    /// <summary>
    /// ✊
    /// </summary>
    [EnumMember(Value = "fist_raised")]
    FistRaised,

    /// <summary>
    /// 👊
    /// </summary>
    [EnumMember(Value = "fist_oncoming")]
    FistOncoming,

    /// <summary>
    /// 🤛
    /// </summary>
    [EnumMember(Value = "fist_left")]
    FistLeft,

    /// <summary>
    /// 🤜
    /// </summary>
    [EnumMember(Value = "fist_right")]
    FistRight,

    /// <summary>
    /// 👏
    /// </summary>
    [EnumMember(Value = "clap")]
    Clap,

    /// <summary>
    /// 🙌
    /// </summary>
    [EnumMember(Value = "raised_hands")]
    RaisedHands,

    /// <summary>
    /// 👐
    /// </summary>
    [EnumMember(Value = "open_hands")]
    OpenHands,

    /// <summary>
    /// 🤲
    /// </summary>
    [EnumMember(Value = "palms_up_together")]
    PalmsUpTogether,

    /// <summary>
    /// 🤝
    /// </summary>
    [EnumMember(Value = "handshake")]
    Handshake,

    /// <summary>
    /// 🙏
    /// </summary>
    [EnumMember(Value = "pray")]
    Pray,

    /// <summary>
    /// ✍️
    /// </summary>
    [EnumMember(Value = "writing_hand")]
    WritingHand,

    /// <summary>
    /// 💅
    /// </summary>
    [EnumMember(Value = "nail_care")]
    NailCare,

    /// <summary>
    /// 🤳
    /// </summary>
    [EnumMember(Value = "selfie")]
    Selfie,

    /// <summary>
    /// 💪
    /// </summary>
    [EnumMember(Value = "muscle")]
    Muscle,

    /// <summary>
    /// 🦾
    /// </summary>
    [EnumMember(Value = "mechanical_arm")]
    MechanicalArm,

    /// <summary>
    /// 🦿
    /// </summary>
    [EnumMember(Value = "mechanical_leg")]
    MechanicalLeg,

    /// <summary>
    /// 🦵
    /// </summary>
    [EnumMember(Value = "leg")]
    Leg,

    /// <summary>
    /// 🦶
    /// </summary>
    [EnumMember(Value = "foot")]
    Foot,

    /// <summary>
    /// 👂
    /// </summary>
    [EnumMember(Value = "ear")]
    Ear,

    /// <summary>
    /// 🦻
    /// </summary>
    [EnumMember(Value = "ear_with_hearing_aid")]
    EarWithHearingAid,

    /// <summary>
    /// 👃
    /// </summary>
    [EnumMember(Value = "nose")]
    Nose,

    /// <summary>
    /// 🧠
    /// </summary>
    [EnumMember(Value = "brain")]
    Brain,

    /// <summary>
    /// 🫀
    /// </summary>
    [EnumMember(Value = "anatomical_heart")]
    AnatomicalHeart,

    /// <summary>
    /// 🫁
    /// </summary>
    [EnumMember(Value = "lungs")]
    Lungs,

    /// <summary>
    /// 🦷
    /// </summary>
    [EnumMember(Value = "tooth")]
    Tooth,

    /// <summary>
    /// 🦴
    /// </summary>
    [EnumMember(Value = "bone")]
    Bone,

    /// <summary>
    /// 👀
    /// </summary>
    [EnumMember(Value = "eyes")]
    Eyes,

    /// <summary>
    /// 👁️
    /// </summary>
    [EnumMember(Value = "eye")]
    Eye,

    /// <summary>
    /// 👅
    /// </summary>
    [EnumMember(Value = "tongue")]
    Tongue,

    /// <summary>
    /// 👄
    /// </summary>
    [EnumMember(Value = "lips")]
    Lips,

    /// <summary>
    /// 👶
    /// </summary>
    [EnumMember(Value = "baby")]
    Baby,

    /// <summary>
    /// 🧒
    /// </summary>
    [EnumMember(Value = "child")]
    Child,

    /// <summary>
    /// 👦
    /// </summary>
    [EnumMember(Value = "boy")]
    Boy,

    /// <summary>
    /// 👧
    /// </summary>
    [EnumMember(Value = "girl")]
    Girl,

    /// <summary>
    /// 🧑
    /// </summary>
    [EnumMember(Value = "adult")]
    Adult,

    /// <summary>
    /// 👱
    /// </summary>
    [EnumMember(Value = "blond_haired_person")]
    BlondHairedPerson,

    /// <summary>
    /// 👨
    /// </summary>
    [EnumMember(Value = "man")]
    Man,

    /// <summary>
    /// 🧔
    /// </summary>
    [EnumMember(Value = "bearded_person")]
    BeardedPerson,

    /// <summary>
    /// 🧔‍♂️
    /// </summary>
    [EnumMember(Value = "man_beard")]
    ManBeard,

    /// <summary>
    /// 🧔‍♀️
    /// </summary>
    [EnumMember(Value = "woman_beard")]
    WomanBeard,

    /// <summary>
    /// 👨‍🦰
    /// </summary>
    [EnumMember(Value = "red_haired_man")]
    RedHairedMan,

    /// <summary>
    /// 👨‍🦱
    /// </summary>
    [EnumMember(Value = "curly_haired_man")]
    CurlyHairedMan,

    /// <summary>
    /// 👨‍🦳
    /// </summary>
    [EnumMember(Value = "white_haired_man")]
    WhiteHairedMan,

    /// <summary>
    /// 👨‍🦲
    /// </summary>
    [EnumMember(Value = "bald_man")]
    BaldMan,

    /// <summary>
    /// 👩
    /// </summary>
    [EnumMember(Value = "woman")]
    Woman,

    /// <summary>
    /// 👩‍🦰
    /// </summary>
    [EnumMember(Value = "red_haired_woman")]
    RedHairedWoman,

    /// <summary>
    /// 🧑‍🦰
    /// </summary>
    [EnumMember(Value = "person_red_hair")]
    PersonRedHair,

    /// <summary>
    /// 👩‍🦱
    /// </summary>
    [EnumMember(Value = "curly_haired_woman")]
    CurlyHairedWoman,

    /// <summary>
    /// 🧑‍🦱
    /// </summary>
    [EnumMember(Value = "person_curly_hair")]
    PersonCurlyHair,

    /// <summary>
    /// 👩‍🦳
    /// </summary>
    [EnumMember(Value = "white_haired_woman")]
    WhiteHairedWoman,

    /// <summary>
    /// 🧑‍🦳
    /// </summary>
    [EnumMember(Value = "person_white_hair")]
    PersonWhiteHair,

    /// <summary>
    /// 👩‍🦲
    /// </summary>
    [EnumMember(Value = "bald_woman")]
    BaldWoman,

    /// <summary>
    /// 🧑‍🦲
    /// </summary>
    [EnumMember(Value = "person_bald")]
    PersonBald,

    /// <summary>
    /// 👱‍♀️
    /// </summary>
    [EnumMember(Value = "blond_haired_woman")]
    BlondHairedWoman,

    /// <summary>
    /// 👱‍♂️
    /// </summary>
    [EnumMember(Value = "blond_haired_man")]
    BlondHairedMan,

    /// <summary>
    /// 🧓
    /// </summary>
    [EnumMember(Value = "older_adult")]
    OlderAdult,

    /// <summary>
    /// 👴
    /// </summary>
    [EnumMember(Value = "older_man")]
    OlderMan,

    /// <summary>
    /// 👵
    /// </summary>
    [EnumMember(Value = "older_woman")]
    OlderWoman,

    /// <summary>
    /// 🙍
    /// </summary>
    [EnumMember(Value = "frowning_person")]
    FrowningPerson,

    /// <summary>
    /// 🙍‍♂️
    /// </summary>
    [EnumMember(Value = "frowning_man")]
    FrowningMan,

    /// <summary>
    /// 🙍‍♀️
    /// </summary>
    [EnumMember(Value = "frowning_woman")]
    FrowningWoman,

    /// <summary>
    /// 🙎
    /// </summary>
    [EnumMember(Value = "pouting_face")]
    PoutingFace,

    /// <summary>
    /// 🙎‍♂️
    /// </summary>
    [EnumMember(Value = "pouting_man")]
    PoutingMan,

    /// <summary>
    /// 🙎‍♀️
    /// </summary>
    [EnumMember(Value = "pouting_woman")]
    PoutingWoman,

    /// <summary>
    /// 🙅
    /// </summary>
    [EnumMember(Value = "no_good")]
    NoGood,

    /// <summary>
    /// 🙅‍♂️
    /// </summary>
    [EnumMember(Value = "no_good_man")]
    NoGoodMan,

    /// <summary>
    /// 🙅‍♀️
    /// </summary>
    [EnumMember(Value = "no_good_woman")]
    NoGoodWoman,

    /// <summary>
    /// 🙆
    /// </summary>
    [EnumMember(Value = "ok_person")]
    OkPerson,

    /// <summary>
    /// 🙆‍♂️
    /// </summary>
    [EnumMember(Value = "ok_man")]
    OkMan,

    /// <summary>
    /// 🙆‍♀️
    /// </summary>
    [EnumMember(Value = "ok_woman")]
    OkWoman,

    /// <summary>
    /// 💁
    /// </summary>
    [EnumMember(Value = "tipping_hand_person")]
    TippingHandPerson,

    /// <summary>
    /// 💁‍♂️
    /// </summary>
    [EnumMember(Value = "tipping_hand_man")]
    TippingHandMan,

    /// <summary>
    /// 💁‍♀️
    /// </summary>
    [EnumMember(Value = "tipping_hand_woman")]
    TippingHandWoman,

    /// <summary>
    /// 🙋
    /// </summary>
    [EnumMember(Value = "raising_hand")]
    RaisingHand,

    /// <summary>
    /// 🙋‍♂️
    /// </summary>
    [EnumMember(Value = "raising_hand_man")]
    RaisingHandMan,

    /// <summary>
    /// 🙋‍♀️
    /// </summary>
    [EnumMember(Value = "raising_hand_woman")]
    RaisingHandWoman,

    /// <summary>
    /// 🧏
    /// </summary>
    [EnumMember(Value = "deaf_person")]
    DeafPerson,

    /// <summary>
    /// 🧏‍♂️
    /// </summary>
    [EnumMember(Value = "deaf_man")]
    DeafMan,

    /// <summary>
    /// 🧏‍♀️
    /// </summary>
    [EnumMember(Value = "deaf_woman")]
    DeafWoman,

    /// <summary>
    /// 🙇
    /// </summary>
    [EnumMember(Value = "bow")]
    Bow,

    /// <summary>
    /// 🙇‍♂️
    /// </summary>
    [EnumMember(Value = "bowing_man")]
    BowingMan,

    /// <summary>
    /// 🙇‍♀️
    /// </summary>
    [EnumMember(Value = "bowing_woman")]
    BowingWoman,

    /// <summary>
    /// 🤦
    /// </summary>
    [EnumMember(Value = "facepalm")]
    Facepalm,

    /// <summary>
    /// 🤦‍♂️
    /// </summary>
    [EnumMember(Value = "man_facepalming")]
    ManFacepalming,

    /// <summary>
    /// 🤦‍♀️
    /// </summary>
    [EnumMember(Value = "woman_facepalming")]
    WomanFacepalming,

    /// <summary>
    /// 🤷
    /// </summary>
    [EnumMember(Value = "shrug")]
    Shrug,

    /// <summary>
    /// 🤷‍♂️
    /// </summary>
    [EnumMember(Value = "man_shrugging")]
    ManShrugging,

    /// <summary>
    /// 🤷‍♀️
    /// </summary>
    [EnumMember(Value = "woman_shrugging")]
    WomanShrugging,

    /// <summary>
    /// 🧑‍⚕️
    /// </summary>
    [EnumMember(Value = "health_worker")]
    HealthWorker,

    /// <summary>
    /// 👨‍⚕️
    /// </summary>
    [EnumMember(Value = "man_health_worker")]
    ManHealthWorker,

    /// <summary>
    /// 👩‍⚕️
    /// </summary>
    [EnumMember(Value = "woman_health_worker")]
    WomanHealthWorker,

    /// <summary>
    /// 🧑‍🎓
    /// </summary>
    [EnumMember(Value = "student")]
    Student,

    /// <summary>
    /// 👨‍🎓
    /// </summary>
    [EnumMember(Value = "man_student")]
    ManStudent,

    /// <summary>
    /// 👩‍🎓
    /// </summary>
    [EnumMember(Value = "woman_student")]
    WomanStudent,

    /// <summary>
    /// 🧑‍🏫
    /// </summary>
    [EnumMember(Value = "teacher")]
    Teacher,

    /// <summary>
    /// 👨‍🏫
    /// </summary>
    [EnumMember(Value = "man_teacher")]
    ManTeacher,

    /// <summary>
    /// 👩‍🏫
    /// </summary>
    [EnumMember(Value = "woman_teacher")]
    WomanTeacher,

    /// <summary>
    /// 🧑‍⚖️
    /// </summary>
    [EnumMember(Value = "judge")]
    Judge,

    /// <summary>
    /// 👨‍⚖️
    /// </summary>
    [EnumMember(Value = "man_judge")]
    ManJudge,

    /// <summary>
    /// 👩‍⚖️
    /// </summary>
    [EnumMember(Value = "woman_judge")]
    WomanJudge,

    /// <summary>
    /// 🧑‍🌾
    /// </summary>
    [EnumMember(Value = "farmer")]
    Farmer,

    /// <summary>
    /// 👨‍🌾
    /// </summary>
    [EnumMember(Value = "man_farmer")]
    ManFarmer,

    /// <summary>
    /// 👩‍🌾
    /// </summary>
    [EnumMember(Value = "woman_farmer")]
    WomanFarmer,

    /// <summary>
    /// 🧑‍🍳
    /// </summary>
    [EnumMember(Value = "cook")]
    Cook,

    /// <summary>
    /// 👨‍🍳
    /// </summary>
    [EnumMember(Value = "man_cook")]
    ManCook,

    /// <summary>
    /// 👩‍🍳
    /// </summary>
    [EnumMember(Value = "woman_cook")]
    WomanCook,

    /// <summary>
    /// 🧑‍🔧
    /// </summary>
    [EnumMember(Value = "mechanic")]
    Mechanic,

    /// <summary>
    /// 👨‍🔧
    /// </summary>
    [EnumMember(Value = "man_mechanic")]
    ManMechanic,

    /// <summary>
    /// 👩‍🔧
    /// </summary>
    [EnumMember(Value = "woman_mechanic")]
    WomanMechanic,

    /// <summary>
    /// 🧑‍🏭
    /// </summary>
    [EnumMember(Value = "factory_worker")]
    FactoryWorker,

    /// <summary>
    /// 👨‍🏭
    /// </summary>
    [EnumMember(Value = "man_factory_worker")]
    ManFactoryWorker,

    /// <summary>
    /// 👩‍🏭
    /// </summary>
    [EnumMember(Value = "woman_factory_worker")]
    WomanFactoryWorker,

    /// <summary>
    /// 🧑‍💼
    /// </summary>
    [EnumMember(Value = "office_worker")]
    OfficeWorker,

    /// <summary>
    /// 👨‍💼
    /// </summary>
    [EnumMember(Value = "man_office_worker")]
    ManOfficeWorker,

    /// <summary>
    /// 👩‍💼
    /// </summary>
    [EnumMember(Value = "woman_office_worker")]
    WomanOfficeWorker,

    /// <summary>
    /// 🧑‍🔬
    /// </summary>
    [EnumMember(Value = "scientist")]
    Scientist,

    /// <summary>
    /// 👨‍🔬
    /// </summary>
    [EnumMember(Value = "man_scientist")]
    ManScientist,

    /// <summary>
    /// 👩‍🔬
    /// </summary>
    [EnumMember(Value = "woman_scientist")]
    WomanScientist,

    /// <summary>
    /// 🧑‍💻
    /// </summary>
    [EnumMember(Value = "technologist")]
    Technologist,

    /// <summary>
    /// 👨‍💻
    /// </summary>
    [EnumMember(Value = "man_technologist")]
    ManTechnologist,

    /// <summary>
    /// 👩‍💻
    /// </summary>
    [EnumMember(Value = "woman_technologist")]
    WomanTechnologist,

    /// <summary>
    /// 🧑‍🎤
    /// </summary>
    [EnumMember(Value = "singer")]
    Singer,

    /// <summary>
    /// 👨‍🎤
    /// </summary>
    [EnumMember(Value = "man_singer")]
    ManSinger,

    /// <summary>
    /// 👩‍🎤
    /// </summary>
    [EnumMember(Value = "woman_singer")]
    WomanSinger,

    /// <summary>
    /// 🧑‍🎨
    /// </summary>
    [EnumMember(Value = "artist")]
    Artist,

    /// <summary>
    /// 👨‍🎨
    /// </summary>
    [EnumMember(Value = "man_artist")]
    ManArtist,

    /// <summary>
    /// 👩‍🎨
    /// </summary>
    [EnumMember(Value = "woman_artist")]
    WomanArtist,

    /// <summary>
    /// 🧑‍✈️
    /// </summary>
    [EnumMember(Value = "pilot")]
    Pilot,

    /// <summary>
    /// 👨‍✈️
    /// </summary>
    [EnumMember(Value = "man_pilot")]
    ManPilot,

    /// <summary>
    /// 👩‍✈️
    /// </summary>
    [EnumMember(Value = "woman_pilot")]
    WomanPilot,

    /// <summary>
    /// 🧑‍🚀
    /// </summary>
    [EnumMember(Value = "astronaut")]
    Astronaut,

    /// <summary>
    /// 👨‍🚀
    /// </summary>
    [EnumMember(Value = "man_astronaut")]
    ManAstronaut,

    /// <summary>
    /// 👩‍🚀
    /// </summary>
    [EnumMember(Value = "woman_astronaut")]
    WomanAstronaut,

    /// <summary>
    /// 🧑‍🚒
    /// </summary>
    [EnumMember(Value = "firefighter")]
    Firefighter,

    /// <summary>
    /// 👨‍🚒
    /// </summary>
    [EnumMember(Value = "man_firefighter")]
    ManFirefighter,

    /// <summary>
    /// 👩‍🚒
    /// </summary>
    [EnumMember(Value = "woman_firefighter")]
    WomanFirefighter,

    /// <summary>
    /// 👮
    /// </summary>
    [EnumMember(Value = "police_officer")]
    PoliceOfficer,

    /// <summary>
    /// 👮‍♂️
    /// </summary>
    [EnumMember(Value = "policeman")]
    Policeman,

    /// <summary>
    /// 👮‍♀️
    /// </summary>
    [EnumMember(Value = "policewoman")]
    Policewoman,

    /// <summary>
    /// 🕵️
    /// </summary>
    [EnumMember(Value = "detective")]
    Detective,

    /// <summary>
    /// 🕵️‍♂️
    /// </summary>
    [EnumMember(Value = "male_detective")]
    MaleDetective,

    /// <summary>
    /// 🕵️‍♀️
    /// </summary>
    [EnumMember(Value = "female_detective")]
    FemaleDetective,

    /// <summary>
    /// 💂
    /// </summary>
    [EnumMember(Value = "guard")]
    Guard,

    /// <summary>
    /// 💂‍♂️
    /// </summary>
    [EnumMember(Value = "guardsman")]
    Guardsman,

    /// <summary>
    /// 💂‍♀️
    /// </summary>
    [EnumMember(Value = "guardswoman")]
    Guardswoman,

    /// <summary>
    /// 🥷
    /// </summary>
    [EnumMember(Value = "ninja")]
    Ninja,

    /// <summary>
    /// 👷
    /// </summary>
    [EnumMember(Value = "construction_worker")]
    ConstructionWorker,

    /// <summary>
    /// 👷‍♂️
    /// </summary>
    [EnumMember(Value = "construction_worker_man")]
    ConstructionWorkerMan,

    /// <summary>
    /// 👷‍♀️
    /// </summary>
    [EnumMember(Value = "construction_worker_woman")]
    ConstructionWorkerWoman,

    /// <summary>
    /// 🤴
    /// </summary>
    [EnumMember(Value = "prince")]
    Prince,

    /// <summary>
    /// 👸
    /// </summary>
    [EnumMember(Value = "princess")]
    Princess,

    /// <summary>
    /// 👳
    /// </summary>
    [EnumMember(Value = "person_with_turban")]
    PersonWithTurban,

    /// <summary>
    /// 👳‍♂️
    /// </summary>
    [EnumMember(Value = "man_with_turban")]
    ManWithTurban,

    /// <summary>
    /// 👳‍♀️
    /// </summary>
    [EnumMember(Value = "woman_with_turban")]
    WomanWithTurban,

    /// <summary>
    /// 👲
    /// </summary>
    [EnumMember(Value = "man_with_gua_pi_mao")]
    ManWithGuaPiMao,

    /// <summary>
    /// 🧕
    /// </summary>
    [EnumMember(Value = "woman_with_headscarf")]
    WomanWithHeadscarf,

    /// <summary>
    /// 🤵
    /// </summary>
    [EnumMember(Value = "person_in_tuxedo")]
    PersonInTuxedo,

    /// <summary>
    /// 🤵‍♂️
    /// </summary>
    [EnumMember(Value = "man_in_tuxedo")]
    ManInTuxedo,

    /// <summary>
    /// 🤵‍♀️
    /// </summary>
    [EnumMember(Value = "woman_in_tuxedo")]
    WomanInTuxedo,

    /// <summary>
    /// 👰
    /// </summary>
    [EnumMember(Value = "person_with_veil")]
    PersonWithVeil,

    /// <summary>
    /// 👰‍♂️
    /// </summary>
    [EnumMember(Value = "man_with_veil")]
    ManWithVeil,

    /// <summary>
    /// 👰‍♀️
    /// </summary>
    [EnumMember(Value = "woman_with_veil")]
    WomanWithVeil,

    /// <summary>
    /// 🤰
    /// </summary>
    [EnumMember(Value = "pregnant_woman")]
    PregnantWoman,

    /// <summary>
    /// 🤱
    /// </summary>
    [EnumMember(Value = "breast_feeding")]
    BreastFeeding,

    /// <summary>
    /// 👩‍🍼
    /// </summary>
    [EnumMember(Value = "woman_feeding_baby")]
    WomanFeedingBaby,

    /// <summary>
    /// 👨‍🍼
    /// </summary>
    [EnumMember(Value = "man_feeding_baby")]
    ManFeedingBaby,

    /// <summary>
    /// 🧑‍🍼
    /// </summary>
    [EnumMember(Value = "person_feeding_baby")]
    PersonFeedingBaby,

    /// <summary>
    /// 👼
    /// </summary>
    [EnumMember(Value = "angel")]
    Angel,

    /// <summary>
    /// 🎅
    /// </summary>
    [EnumMember(Value = "santa")]
    Santa,

    /// <summary>
    /// 🤶
    /// </summary>
    [EnumMember(Value = "mrs_claus")]
    MrsClaus,

    /// <summary>
    /// 🧑‍🎄
    /// </summary>
    [EnumMember(Value = "mx_claus")]
    MxClaus,

    /// <summary>
    /// 🦸
    /// </summary>
    [EnumMember(Value = "superhero")]
    Superhero,

    /// <summary>
    /// 🦸‍♂️
    /// </summary>
    [EnumMember(Value = "superhero_man")]
    SuperheroMan,

    /// <summary>
    /// 🦸‍♀️
    /// </summary>
    [EnumMember(Value = "superhero_woman")]
    SuperheroWoman,

    /// <summary>
    /// 🦹
    /// </summary>
    [EnumMember(Value = "supervillain")]
    Supervillain,

    /// <summary>
    /// 🦹‍♂️
    /// </summary>
    [EnumMember(Value = "supervillain_man")]
    SupervillainMan,

    /// <summary>
    /// 🦹‍♀️
    /// </summary>
    [EnumMember(Value = "supervillain_woman")]
    SupervillainWoman,

    /// <summary>
    /// 🧙
    /// </summary>
    [EnumMember(Value = "mage")]
    Mage,

    /// <summary>
    /// 🧙‍♂️
    /// </summary>
    [EnumMember(Value = "mage_man")]
    MageMan,

    /// <summary>
    /// 🧙‍♀️
    /// </summary>
    [EnumMember(Value = "mage_woman")]
    MageWoman,

    /// <summary>
    /// 🧚
    /// </summary>
    [EnumMember(Value = "fairy")]
    Fairy,

    /// <summary>
    /// 🧚‍♂️
    /// </summary>
    [EnumMember(Value = "fairy_man")]
    FairyMan,

    /// <summary>
    /// 🧚‍♀️
    /// </summary>
    [EnumMember(Value = "fairy_woman")]
    FairyWoman,

    /// <summary>
    /// 🧛
    /// </summary>
    [EnumMember(Value = "vampire")]
    Vampire,

    /// <summary>
    /// 🧛‍♂️
    /// </summary>
    [EnumMember(Value = "vampire_man")]
    VampireMan,

    /// <summary>
    /// 🧛‍♀️
    /// </summary>
    [EnumMember(Value = "vampire_woman")]
    VampireWoman,

    /// <summary>
    /// 🧜
    /// </summary>
    [EnumMember(Value = "merperson")]
    Merperson,

    /// <summary>
    /// 🧜‍♂️
    /// </summary>
    [EnumMember(Value = "merman")]
    Merman,

    /// <summary>
    /// 🧜‍♀️
    /// </summary>
    [EnumMember(Value = "mermaid")]
    Mermaid,

    /// <summary>
    /// 🧝
    /// </summary>
    [EnumMember(Value = "elf")]
    Elf,

    /// <summary>
    /// 🧝‍♂️
    /// </summary>
    [EnumMember(Value = "elf_man")]
    ElfMan,

    /// <summary>
    /// 🧝‍♀️
    /// </summary>
    [EnumMember(Value = "elf_woman")]
    ElfWoman,

    /// <summary>
    /// 🧞
    /// </summary>
    [EnumMember(Value = "genie")]
    Genie,

    /// <summary>
    /// 🧞‍♂️
    /// </summary>
    [EnumMember(Value = "genie_man")]
    GenieMan,

    /// <summary>
    /// 🧞‍♀️
    /// </summary>
    [EnumMember(Value = "genie_woman")]
    GenieWoman,

    /// <summary>
    /// 🧟
    /// </summary>
    [EnumMember(Value = "zombie")]
    Zombie,

    /// <summary>
    /// 🧟‍♂️
    /// </summary>
    [EnumMember(Value = "zombie_man")]
    ZombieMan,

    /// <summary>
    /// 🧟‍♀️
    /// </summary>
    [EnumMember(Value = "zombie_woman")]
    ZombieWoman,

    /// <summary>
    /// 💆
    /// </summary>
    [EnumMember(Value = "massage")]
    Massage,

    /// <summary>
    /// 💆‍♂️
    /// </summary>
    [EnumMember(Value = "massage_man")]
    MassageMan,

    /// <summary>
    /// 💆‍♀️
    /// </summary>
    [EnumMember(Value = "massage_woman")]
    MassageWoman,

    /// <summary>
    /// 💇
    /// </summary>
    [EnumMember(Value = "haircut")]
    Haircut,

    /// <summary>
    /// 💇‍♂️
    /// </summary>
    [EnumMember(Value = "haircut_man")]
    HaircutMan,

    /// <summary>
    /// 💇‍♀️
    /// </summary>
    [EnumMember(Value = "haircut_woman")]
    HaircutWoman,

    /// <summary>
    /// 🚶
    /// </summary>
    [EnumMember(Value = "walking")]
    Walking,

    /// <summary>
    /// 🚶‍♂️
    /// </summary>
    [EnumMember(Value = "walking_man")]
    WalkingMan,

    /// <summary>
    /// 🚶‍♀️
    /// </summary>
    [EnumMember(Value = "walking_woman")]
    WalkingWoman,

    /// <summary>
    /// 🧍
    /// </summary>
    [EnumMember(Value = "standing_person")]
    StandingPerson,

    /// <summary>
    /// 🧍‍♂️
    /// </summary>
    [EnumMember(Value = "standing_man")]
    StandingMan,

    /// <summary>
    /// 🧍‍♀️
    /// </summary>
    [EnumMember(Value = "standing_woman")]
    StandingWoman,

    /// <summary>
    /// 🧎
    /// </summary>
    [EnumMember(Value = "kneeling_person")]
    KneelingPerson,

    /// <summary>
    /// 🧎‍♂️
    /// </summary>
    [EnumMember(Value = "kneeling_man")]
    KneelingMan,

    /// <summary>
    /// 🧎‍♀️
    /// </summary>
    [EnumMember(Value = "kneeling_woman")]
    KneelingWoman,

    /// <summary>
    /// 🧑‍🦯
    /// </summary>
    [EnumMember(Value = "person_with_probing_cane")]
    PersonWithProbingCane,

    /// <summary>
    /// 👨‍🦯
    /// </summary>
    [EnumMember(Value = "man_with_probing_cane")]
    ManWithProbingCane,

    /// <summary>
    /// 👩‍🦯
    /// </summary>
    [EnumMember(Value = "woman_with_probing_cane")]
    WomanWithProbingCane,

    /// <summary>
    /// 🧑‍🦼
    /// </summary>
    [EnumMember(Value = "person_in_motorized_wheelchair")]
    PersonInMotorizedWheelchair,

    /// <summary>
    /// 👨‍🦼
    /// </summary>
    [EnumMember(Value = "man_in_motorized_wheelchair")]
    ManInMotorizedWheelchair,

    /// <summary>
    /// 👩‍🦼
    /// </summary>
    [EnumMember(Value = "woman_in_motorized_wheelchair")]
    WomanInMotorizedWheelchair,

    /// <summary>
    /// 🧑‍🦽
    /// </summary>
    [EnumMember(Value = "person_in_manual_wheelchair")]
    PersonInManualWheelchair,

    /// <summary>
    /// 👨‍🦽
    /// </summary>
    [EnumMember(Value = "man_in_manual_wheelchair")]
    ManInManualWheelchair,

    /// <summary>
    /// 👩‍🦽
    /// </summary>
    [EnumMember(Value = "woman_in_manual_wheelchair")]
    WomanInManualWheelchair,

    /// <summary>
    /// 🏃
    /// </summary>
    [EnumMember(Value = "runner")]
    Runner,

    /// <summary>
    /// 🏃‍♂️
    /// </summary>
    [EnumMember(Value = "running_man")]
    RunningMan,

    /// <summary>
    /// 🏃‍♀️
    /// </summary>
    [EnumMember(Value = "running_woman")]
    RunningWoman,

    /// <summary>
    /// 💃
    /// </summary>
    [EnumMember(Value = "woman_dancing")]
    WomanDancing,

    /// <summary>
    /// 🕺
    /// </summary>
    [EnumMember(Value = "man_dancing")]
    ManDancing,

    /// <summary>
    /// 🕴️
    /// </summary>
    [EnumMember(Value = "business_suit_levitating")]
    BusinessSuitLevitating,

    /// <summary>
    /// 👯
    /// </summary>
    [EnumMember(Value = "dancers")]
    Dancers,

    /// <summary>
    /// 👯‍♂️
    /// </summary>
    [EnumMember(Value = "dancing_men")]
    DancingMen,

    /// <summary>
    /// 👯‍♀️
    /// </summary>
    [EnumMember(Value = "dancing_women")]
    DancingWomen,

    /// <summary>
    /// 🧖
    /// </summary>
    [EnumMember(Value = "sauna_person")]
    SaunaPerson,

    /// <summary>
    /// 🧖‍♂️
    /// </summary>
    [EnumMember(Value = "sauna_man")]
    SaunaMan,

    /// <summary>
    /// 🧖‍♀️
    /// </summary>
    [EnumMember(Value = "sauna_woman")]
    SaunaWoman,

    /// <summary>
    /// 🧗
    /// </summary>
    [EnumMember(Value = "climbing")]
    Climbing,

    /// <summary>
    /// 🧗‍♂️
    /// </summary>
    [EnumMember(Value = "climbing_man")]
    ClimbingMan,

    /// <summary>
    /// 🧗‍♀️
    /// </summary>
    [EnumMember(Value = "climbing_woman")]
    ClimbingWoman,

    /// <summary>
    /// 🤺
    /// </summary>
    [EnumMember(Value = "person_fencing")]
    PersonFencing,

    /// <summary>
    /// 🏇
    /// </summary>
    [EnumMember(Value = "horse_racing")]
    HorseRacing,

    /// <summary>
    /// ⛷️
    /// </summary>
    [EnumMember(Value = "skier")]
    Skier,

    /// <summary>
    /// 🏂
    /// </summary>
    [EnumMember(Value = "snowboarder")]
    Snowboarder,

    /// <summary>
    /// 🏌️
    /// </summary>
    [EnumMember(Value = "golfing")]
    Golfing,

    /// <summary>
    /// 🏌️‍♂️
    /// </summary>
    [EnumMember(Value = "golfing_man")]
    GolfingMan,

    /// <summary>
    /// 🏌️‍♀️
    /// </summary>
    [EnumMember(Value = "golfing_woman")]
    GolfingWoman,

    /// <summary>
    /// 🏄
    /// </summary>
    [EnumMember(Value = "surfer")]
    Surfer,

    /// <summary>
    /// 🏄‍♂️
    /// </summary>
    [EnumMember(Value = "surfing_man")]
    SurfingMan,

    /// <summary>
    /// 🏄‍♀️
    /// </summary>
    [EnumMember(Value = "surfing_woman")]
    SurfingWoman,

    /// <summary>
    /// 🚣
    /// </summary>
    [EnumMember(Value = "rowboat")]
    Rowboat,

    /// <summary>
    /// 🚣‍♂️
    /// </summary>
    [EnumMember(Value = "rowing_man")]
    RowingMan,

    /// <summary>
    /// 🚣‍♀️
    /// </summary>
    [EnumMember(Value = "rowing_woman")]
    RowingWoman,

    /// <summary>
    /// 🏊
    /// </summary>
    [EnumMember(Value = "swimmer")]
    Swimmer,

    /// <summary>
    /// 🏊‍♂️
    /// </summary>
    [EnumMember(Value = "swimming_man")]
    SwimmingMan,

    /// <summary>
    /// 🏊‍♀️
    /// </summary>
    [EnumMember(Value = "swimming_woman")]
    SwimmingWoman,

    /// <summary>
    /// ⛹️
    /// </summary>
    [EnumMember(Value = "bouncing_ball_person")]
    BouncingBallPerson,

    /// <summary>
    /// ⛹️‍♂️
    /// </summary>
    [EnumMember(Value = "bouncing_ball_man")]
    BouncingBallMan,

    /// <summary>
    /// ⛹️‍♀️
    /// </summary>
    [EnumMember(Value = "bouncing_ball_woman")]
    BouncingBallWoman,

    /// <summary>
    /// 🏋️
    /// </summary>
    [EnumMember(Value = "weight_lifting")]
    WeightLifting,

    /// <summary>
    /// 🏋️‍♂️
    /// </summary>
    [EnumMember(Value = "weight_lifting_man")]
    WeightLiftingMan,

    /// <summary>
    /// 🏋️‍♀️
    /// </summary>
    [EnumMember(Value = "weight_lifting_woman")]
    WeightLiftingWoman,

    /// <summary>
    /// 🚴
    /// </summary>
    [EnumMember(Value = "bicyclist")]
    Bicyclist,

    /// <summary>
    /// 🚴‍♂️
    /// </summary>
    [EnumMember(Value = "biking_man")]
    BikingMan,

    /// <summary>
    /// 🚴‍♀️
    /// </summary>
    [EnumMember(Value = "biking_woman")]
    BikingWoman,

    /// <summary>
    /// 🚵
    /// </summary>
    [EnumMember(Value = "mountain_bicyclist")]
    MountainBicyclist,

    /// <summary>
    /// 🚵‍♂️
    /// </summary>
    [EnumMember(Value = "mountain_biking_man")]
    MountainBikingMan,

    /// <summary>
    /// 🚵‍♀️
    /// </summary>
    [EnumMember(Value = "mountain_biking_woman")]
    MountainBikingWoman,

    /// <summary>
    /// 🤸
    /// </summary>
    [EnumMember(Value = "cartwheeling")]
    Cartwheeling,

    /// <summary>
    /// 🤸‍♂️
    /// </summary>
    [EnumMember(Value = "man_cartwheeling")]
    ManCartwheeling,

    /// <summary>
    /// 🤸‍♀️
    /// </summary>
    [EnumMember(Value = "woman_cartwheeling")]
    WomanCartwheeling,

    /// <summary>
    /// 🤼
    /// </summary>
    [EnumMember(Value = "wrestling")]
    Wrestling,

    /// <summary>
    /// 🤼‍♂️
    /// </summary>
    [EnumMember(Value = "men_wrestling")]
    MenWrestling,

    /// <summary>
    /// 🤼‍♀️
    /// </summary>
    [EnumMember(Value = "women_wrestling")]
    WomenWrestling,

    /// <summary>
    /// 🤽
    /// </summary>
    [EnumMember(Value = "water_polo")]
    WaterPolo,

    /// <summary>
    /// 🤽‍♂️
    /// </summary>
    [EnumMember(Value = "man_playing_water_polo")]
    ManPlayingWaterPolo,

    /// <summary>
    /// 🤽‍♀️
    /// </summary>
    [EnumMember(Value = "woman_playing_water_polo")]
    WomanPlayingWaterPolo,

    /// <summary>
    /// 🤾
    /// </summary>
    [EnumMember(Value = "handball_person")]
    HandballPerson,

    /// <summary>
    /// 🤾‍♂️
    /// </summary>
    [EnumMember(Value = "man_playing_handball")]
    ManPlayingHandball,

    /// <summary>
    /// 🤾‍♀️
    /// </summary>
    [EnumMember(Value = "woman_playing_handball")]
    WomanPlayingHandball,

    /// <summary>
    /// 🤹
    /// </summary>
    [EnumMember(Value = "juggling_person")]
    JugglingPerson,

    /// <summary>
    /// 🤹‍♂️
    /// </summary>
    [EnumMember(Value = "man_juggling")]
    ManJuggling,

    /// <summary>
    /// 🤹‍♀️
    /// </summary>
    [EnumMember(Value = "woman_juggling")]
    WomanJuggling,

    /// <summary>
    /// 🧘
    /// </summary>
    [EnumMember(Value = "lotus_position")]
    LotusPosition,

    /// <summary>
    /// 🧘‍♂️
    /// </summary>
    [EnumMember(Value = "lotus_position_man")]
    LotusPositionMan,

    /// <summary>
    /// 🧘‍♀️
    /// </summary>
    [EnumMember(Value = "lotus_position_woman")]
    LotusPositionWoman,

    /// <summary>
    /// 🛀
    /// </summary>
    [EnumMember(Value = "bath")]
    Bath,

    /// <summary>
    /// 🛌
    /// </summary>
    [EnumMember(Value = "sleeping_bed")]
    SleepingBed,

    /// <summary>
    /// 🧑‍🤝‍🧑
    /// </summary>
    [EnumMember(Value = "people_holding_hands")]
    PeopleHoldingHands,

    /// <summary>
    /// 👭
    /// </summary>
    [EnumMember(Value = "two_women_holding_hands")]
    TwoWomenHoldingHands,

    /// <summary>
    /// 👫
    /// </summary>
    [EnumMember(Value = "couple")]
    Couple,

    /// <summary>
    /// 👬
    /// </summary>
    [EnumMember(Value = "two_men_holding_hands")]
    TwoMenHoldingHands,

    /// <summary>
    /// 💏
    /// </summary>
    [EnumMember(Value = "couplekiss")]
    Couplekiss,

    /// <summary>
    /// 👩‍❤️‍💋‍👨
    /// </summary>
    [EnumMember(Value = "couplekiss_man_woman")]
    CouplekissManWoman,

    /// <summary>
    /// 👨‍❤️‍💋‍👨
    /// </summary>
    [EnumMember(Value = "couplekiss_man_man")]
    CouplekissManMan,

    /// <summary>
    /// 👩‍❤️‍💋‍👩
    /// </summary>
    [EnumMember(Value = "couplekiss_woman_woman")]
    CouplekissWomanWoman,

    /// <summary>
    /// 💑
    /// </summary>
    [EnumMember(Value = "couple_with_heart")]
    CoupleWithHeart,

    /// <summary>
    /// 👩‍❤️‍👨
    /// </summary>
    [EnumMember(Value = "couple_with_heart_woman_man")]
    CoupleWithHeartWomanMan,

    /// <summary>
    /// 👨‍❤️‍👨
    /// </summary>
    [EnumMember(Value = "couple_with_heart_man_man")]
    CoupleWithHeartManMan,

    /// <summary>
    /// 👩‍❤️‍👩
    /// </summary>
    [EnumMember(Value = "couple_with_heart_woman_woman")]
    CoupleWithHeartWomanWoman,

    /// <summary>
    /// 👪
    /// </summary>
    [EnumMember(Value = "family")]
    Family,

    /// <summary>
    /// 👨‍👩‍👦
    /// </summary>
    [EnumMember(Value = "family_man_woman_boy")]
    FamilyManWomanBoy,

    /// <summary>
    /// 👨‍👩‍👧
    /// </summary>
    [EnumMember(Value = "family_man_woman_girl")]
    FamilyManWomanGirl,

    /// <summary>
    /// 👨‍👩‍👧‍👦
    /// </summary>
    [EnumMember(Value = "family_man_woman_girl_boy")]
    FamilyManWomanGirlBoy,

    /// <summary>
    /// 👨‍👩‍👦‍👦
    /// </summary>
    [EnumMember(Value = "family_man_woman_boy_boy")]
    FamilyManWomanBoyBoy,

    /// <summary>
    /// 👨‍👩‍👧‍👧
    /// </summary>
    [EnumMember(Value = "family_man_woman_girl_girl")]
    FamilyManWomanGirlGirl,

    /// <summary>
    /// 👨‍👨‍👦
    /// </summary>
    [EnumMember(Value = "family_man_man_boy")]
    FamilyManManBoy,

    /// <summary>
    /// 👨‍👨‍👧
    /// </summary>
    [EnumMember(Value = "family_man_man_girl")]
    FamilyManManGirl,

    /// <summary>
    /// 👨‍👨‍👧‍👦
    /// </summary>
    [EnumMember(Value = "family_man_man_girl_boy")]
    FamilyManManGirlBoy,

    /// <summary>
    /// 👨‍👨‍👦‍👦
    /// </summary>
    [EnumMember(Value = "family_man_man_boy_boy")]
    FamilyManManBoyBoy,

    /// <summary>
    /// 👨‍👨‍👧‍👧
    /// </summary>
    [EnumMember(Value = "family_man_man_girl_girl")]
    FamilyManManGirlGirl,

    /// <summary>
    /// 👩‍👩‍👦
    /// </summary>
    [EnumMember(Value = "family_woman_woman_boy")]
    FamilyWomanWomanBoy,

    /// <summary>
    /// 👩‍👩‍👧
    /// </summary>
    [EnumMember(Value = "family_woman_woman_girl")]
    FamilyWomanWomanGirl,

    /// <summary>
    /// 👩‍👩‍👧‍👦
    /// </summary>
    [EnumMember(Value = "family_woman_woman_girl_boy")]
    FamilyWomanWomanGirlBoy,

    /// <summary>
    /// 👩‍👩‍👦‍👦
    /// </summary>
    [EnumMember(Value = "family_woman_woman_boy_boy")]
    FamilyWomanWomanBoyBoy,

    /// <summary>
    /// 👩‍👩‍👧‍👧
    /// </summary>
    [EnumMember(Value = "family_woman_woman_girl_girl")]
    FamilyWomanWomanGirlGirl,

    /// <summary>
    /// 👨‍👦
    /// </summary>
    [EnumMember(Value = "family_man_boy")]
    FamilyManBoy,

    /// <summary>
    /// 👨‍👦‍👦
    /// </summary>
    [EnumMember(Value = "family_man_boy_boy")]
    FamilyManBoyBoy,

    /// <summary>
    /// 👨‍👧
    /// </summary>
    [EnumMember(Value = "family_man_girl")]
    FamilyManGirl,

    /// <summary>
    /// 👨‍👧‍👦
    /// </summary>
    [EnumMember(Value = "family_man_girl_boy")]
    FamilyManGirlBoy,

    /// <summary>
    /// 👨‍👧‍👧
    /// </summary>
    [EnumMember(Value = "family_man_girl_girl")]
    FamilyManGirlGirl,

    /// <summary>
    /// 👩‍👦
    /// </summary>
    [EnumMember(Value = "family_woman_boy")]
    FamilyWomanBoy,

    /// <summary>
    /// 👩‍👦‍👦
    /// </summary>
    [EnumMember(Value = "family_woman_boy_boy")]
    FamilyWomanBoyBoy,

    /// <summary>
    /// 👩‍👧
    /// </summary>
    [EnumMember(Value = "family_woman_girl")]
    FamilyWomanGirl,

    /// <summary>
    /// 👩‍👧‍👦
    /// </summary>
    [EnumMember(Value = "family_woman_girl_boy")]
    FamilyWomanGirlBoy,

    /// <summary>
    /// 👩‍👧‍👧
    /// </summary>
    [EnumMember(Value = "family_woman_girl_girl")]
    FamilyWomanGirlGirl,

    /// <summary>
    /// 🗣️
    /// </summary>
    [EnumMember(Value = "speaking_head")]
    SpeakingHead,

    /// <summary>
    /// 👤
    /// </summary>
    [EnumMember(Value = "bust_in_silhouette")]
    BustInSilhouette,

    /// <summary>
    /// 👥
    /// </summary>
    [EnumMember(Value = "busts_in_silhouette")]
    BustsInSilhouette,

    /// <summary>
    /// 🫂
    /// </summary>
    [EnumMember(Value = "people_hugging")]
    PeopleHugging,

    /// <summary>
    /// 👣
    /// </summary>
    [EnumMember(Value = "footprints")]
    Footprints,

    /// <summary>
    /// 🐵
    /// </summary>
    [EnumMember(Value = "monkey_face")]
    MonkeyFace,

    /// <summary>
    /// 🐒
    /// </summary>
    [EnumMember(Value = "monkey")]
    Monkey,

    /// <summary>
    /// 🦍
    /// </summary>
    [EnumMember(Value = "gorilla")]
    Gorilla,

    /// <summary>
    /// 🦧
    /// </summary>
    [EnumMember(Value = "orangutan")]
    Orangutan,

    /// <summary>
    /// 🐶
    /// </summary>
    [EnumMember(Value = "dog")]
    Dog,

    /// <summary>
    /// 🐕
    /// </summary>
    [EnumMember(Value = "dog2")]
    Dog2,

    /// <summary>
    /// 🦮
    /// </summary>
    [EnumMember(Value = "guide_dog")]
    GuideDog,

    /// <summary>
    /// 🐕‍🦺
    /// </summary>
    [EnumMember(Value = "service_dog")]
    ServiceDog,

    /// <summary>
    /// 🐩
    /// </summary>
    [EnumMember(Value = "poodle")]
    Poodle,

    /// <summary>
    /// 🐺
    /// </summary>
    [EnumMember(Value = "wolf")]
    Wolf,

    /// <summary>
    /// 🦊
    /// </summary>
    [EnumMember(Value = "fox_face")]
    FoxFace,

    /// <summary>
    /// 🦝
    /// </summary>
    [EnumMember(Value = "raccoon")]
    Raccoon,

    /// <summary>
    /// 🐱
    /// </summary>
    [EnumMember(Value = "cat")]
    Cat,

    /// <summary>
    /// 🐈
    /// </summary>
    [EnumMember(Value = "cat2")]
    Cat2,

    /// <summary>
    /// 🐈‍⬛
    /// </summary>
    [EnumMember(Value = "black_cat")]
    BlackCat,

    /// <summary>
    /// 🦁
    /// </summary>
    [EnumMember(Value = "lion")]
    Lion,

    /// <summary>
    /// 🐯
    /// </summary>
    [EnumMember(Value = "tiger")]
    Tiger,

    /// <summary>
    /// 🐅
    /// </summary>
    [EnumMember(Value = "tiger2")]
    Tiger2,

    /// <summary>
    /// 🐆
    /// </summary>
    [EnumMember(Value = "leopard")]
    Leopard,

    /// <summary>
    /// 🐴
    /// </summary>
    [EnumMember(Value = "horse")]
    Horse,

    /// <summary>
    /// 🐎
    /// </summary>
    [EnumMember(Value = "racehorse")]
    Racehorse,

    /// <summary>
    /// 🦄
    /// </summary>
    [EnumMember(Value = "unicorn")]
    Unicorn,

    /// <summary>
    /// 🦓
    /// </summary>
    [EnumMember(Value = "zebra")]
    Zebra,

    /// <summary>
    /// 🦌
    /// </summary>
    [EnumMember(Value = "deer")]
    Deer,

    /// <summary>
    /// 🦬
    /// </summary>
    [EnumMember(Value = "bison")]
    Bison,

    /// <summary>
    /// 🐮
    /// </summary>
    [EnumMember(Value = "cow")]
    Cow,

    /// <summary>
    /// 🐂
    /// </summary>
    [EnumMember(Value = "ox")]
    Ox,

    /// <summary>
    /// 🐃
    /// </summary>
    [EnumMember(Value = "water_buffalo")]
    WaterBuffalo,

    /// <summary>
    /// 🐄
    /// </summary>
    [EnumMember(Value = "cow2")]
    Cow2,

    /// <summary>
    /// 🐷
    /// </summary>
    [EnumMember(Value = "pig")]
    Pig,

    /// <summary>
    /// 🐖
    /// </summary>
    [EnumMember(Value = "pig2")]
    Pig2,

    /// <summary>
    /// 🐗
    /// </summary>
    [EnumMember(Value = "boar")]
    Boar,

    /// <summary>
    /// 🐽
    /// </summary>
    [EnumMember(Value = "pig_nose")]
    PigNose,

    /// <summary>
    /// 🐏
    /// </summary>
    [EnumMember(Value = "ram")]
    Ram,

    /// <summary>
    /// 🐑
    /// </summary>
    [EnumMember(Value = "sheep")]
    Sheep,

    /// <summary>
    /// 🐐
    /// </summary>
    [EnumMember(Value = "goat")]
    Goat,

    /// <summary>
    /// 🐪
    /// </summary>
    [EnumMember(Value = "dromedary_camel")]
    DromedaryCamel,

    /// <summary>
    /// 🐫
    /// </summary>
    [EnumMember(Value = "camel")]
    Camel,

    /// <summary>
    /// 🦙
    /// </summary>
    [EnumMember(Value = "llama")]
    Llama,

    /// <summary>
    /// 🦒
    /// </summary>
    [EnumMember(Value = "giraffe")]
    Giraffe,

    /// <summary>
    /// 🐘
    /// </summary>
    [EnumMember(Value = "elephant")]
    Elephant,

    /// <summary>
    /// 🦣
    /// </summary>
    [EnumMember(Value = "mammoth")]
    Mammoth,

    /// <summary>
    /// 🦏
    /// </summary>
    [EnumMember(Value = "rhinoceros")]
    Rhinoceros,

    /// <summary>
    /// 🦛
    /// </summary>
    [EnumMember(Value = "hippopotamus")]
    Hippopotamus,

    /// <summary>
    /// 🐭
    /// </summary>
    [EnumMember(Value = "mouse")]
    Mouse,

    /// <summary>
    /// 🐁
    /// </summary>
    [EnumMember(Value = "mouse2")]
    Mouse2,

    /// <summary>
    /// 🐀
    /// </summary>
    [EnumMember(Value = "rat")]
    Rat,

    /// <summary>
    /// 🐹
    /// </summary>
    [EnumMember(Value = "hamster")]
    Hamster,

    /// <summary>
    /// 🐰
    /// </summary>
    [EnumMember(Value = "rabbit")]
    Rabbit,

    /// <summary>
    /// 🐇
    /// </summary>
    [EnumMember(Value = "rabbit2")]
    Rabbit2,

    /// <summary>
    /// 🐿️
    /// </summary>
    [EnumMember(Value = "chipmunk")]
    Chipmunk,

    /// <summary>
    /// 🦫
    /// </summary>
    [EnumMember(Value = "beaver")]
    Beaver,

    /// <summary>
    /// 🦔
    /// </summary>
    [EnumMember(Value = "hedgehog")]
    Hedgehog,

    /// <summary>
    /// 🦇
    /// </summary>
    [EnumMember(Value = "bat")]
    Bat,

    /// <summary>
    /// 🐻
    /// </summary>
    [EnumMember(Value = "bear")]
    Bear,

    /// <summary>
    /// 🐻‍❄️
    /// </summary>
    [EnumMember(Value = "polar_bear")]
    PolarBear,

    /// <summary>
    /// 🐨
    /// </summary>
    [EnumMember(Value = "koala")]
    Koala,

    /// <summary>
    /// 🐼
    /// </summary>
    [EnumMember(Value = "panda_face")]
    PandaFace,

    /// <summary>
    /// 🦥
    /// </summary>
    [EnumMember(Value = "sloth")]
    Sloth,

    /// <summary>
    /// 🦦
    /// </summary>
    [EnumMember(Value = "otter")]
    Otter,

    /// <summary>
    /// 🦨
    /// </summary>
    [EnumMember(Value = "skunk")]
    Skunk,

    /// <summary>
    /// 🦘
    /// </summary>
    [EnumMember(Value = "kangaroo")]
    Kangaroo,

    /// <summary>
    /// 🦡
    /// </summary>
    [EnumMember(Value = "badger")]
    Badger,

    /// <summary>
    /// 🐾
    /// </summary>
    [EnumMember(Value = "feet")]
    Feet,

    /// <summary>
    /// 🦃
    /// </summary>
    [EnumMember(Value = "turkey")]
    Turkey,

    /// <summary>
    /// 🐔
    /// </summary>
    [EnumMember(Value = "chicken")]
    Chicken,

    /// <summary>
    /// 🐓
    /// </summary>
    [EnumMember(Value = "rooster")]
    Rooster,

    /// <summary>
    /// 🐣
    /// </summary>
    [EnumMember(Value = "hatching_chick")]
    HatchingChick,

    /// <summary>
    /// 🐤
    /// </summary>
    [EnumMember(Value = "baby_chick")]
    BabyChick,

    /// <summary>
    /// 🐥
    /// </summary>
    [EnumMember(Value = "hatched_chick")]
    HatchedChick,

    /// <summary>
    /// 🐦
    /// </summary>
    [EnumMember(Value = "bird")]
    Bird,

    /// <summary>
    /// 🐧
    /// </summary>
    [EnumMember(Value = "penguin")]
    Penguin,

    /// <summary>
    /// 🕊️
    /// </summary>
    [EnumMember(Value = "dove")]
    Dove,

    /// <summary>
    /// 🦅
    /// </summary>
    [EnumMember(Value = "eagle")]
    Eagle,

    /// <summary>
    /// 🦆
    /// </summary>
    [EnumMember(Value = "duck")]
    Duck,

    /// <summary>
    /// 🦢
    /// </summary>
    [EnumMember(Value = "swan")]
    Swan,

    /// <summary>
    /// 🦉
    /// </summary>
    [EnumMember(Value = "owl")]
    Owl,

    /// <summary>
    /// 🦤
    /// </summary>
    [EnumMember(Value = "dodo")]
    Dodo,

    /// <summary>
    /// 🪶
    /// </summary>
    [EnumMember(Value = "feather")]
    Feather,

    /// <summary>
    /// 🦩
    /// </summary>
    [EnumMember(Value = "flamingo")]
    Flamingo,

    /// <summary>
    /// 🦚
    /// </summary>
    [EnumMember(Value = "peacock")]
    Peacock,

    /// <summary>
    /// 🦜
    /// </summary>
    [EnumMember(Value = "parrot")]
    Parrot,

    /// <summary>
    /// 🐸
    /// </summary>
    [EnumMember(Value = "frog")]
    Frog,

    /// <summary>
    /// 🐊
    /// </summary>
    [EnumMember(Value = "crocodile")]
    Crocodile,

    /// <summary>
    /// 🐢
    /// </summary>
    [EnumMember(Value = "turtle")]
    Turtle,

    /// <summary>
    /// 🦎
    /// </summary>
    [EnumMember(Value = "lizard")]
    Lizard,

    /// <summary>
    /// 🐍
    /// </summary>
    [EnumMember(Value = "snake")]
    Snake,

    /// <summary>
    /// 🐲
    /// </summary>
    [EnumMember(Value = "dragon_face")]
    DragonFace,

    /// <summary>
    /// 🐉
    /// </summary>
    [EnumMember(Value = "dragon")]
    Dragon,

    /// <summary>
    /// 🦕
    /// </summary>
    [EnumMember(Value = "sauropod")]
    Sauropod,

    /// <summary>
    /// 🦖
    /// </summary>
    [EnumMember(Value = "t-rex")]
    TRex,

    /// <summary>
    /// 🐳
    /// </summary>
    [EnumMember(Value = "whale")]
    Whale,

    /// <summary>
    /// 🐋
    /// </summary>
    [EnumMember(Value = "whale2")]
    Whale2,

    /// <summary>
    /// 🐬
    /// </summary>
    [EnumMember(Value = "dolphin")]
    Dolphin,

    /// <summary>
    /// 🦭
    /// </summary>
    [EnumMember(Value = "seal")]
    Seal,

    /// <summary>
    /// 🐟
    /// </summary>
    [EnumMember(Value = "fish")]
    Fish,

    /// <summary>
    /// 🐠
    /// </summary>
    [EnumMember(Value = "tropical_fish")]
    TropicalFish,

    /// <summary>
    /// 🐡
    /// </summary>
    [EnumMember(Value = "blowfish")]
    Blowfish,

    /// <summary>
    /// 🦈
    /// </summary>
    [EnumMember(Value = "shark")]
    Shark,

    /// <summary>
    /// 🐙
    /// </summary>
    [EnumMember(Value = "octopus")]
    Octopus,

    /// <summary>
    /// 🐚
    /// </summary>
    [EnumMember(Value = "shell")]
    Shell,

    /// <summary>
    /// 🐌
    /// </summary>
    [EnumMember(Value = "snail")]
    Snail,

    /// <summary>
    /// 🦋
    /// </summary>
    [EnumMember(Value = "butterfly")]
    Butterfly,

    /// <summary>
    /// 🐛
    /// </summary>
    [EnumMember(Value = "bug")]
    Bug,

    /// <summary>
    /// 🐜
    /// </summary>
    [EnumMember(Value = "ant")]
    Ant,

    /// <summary>
    /// 🐝
    /// </summary>
    [EnumMember(Value = "bee")]
    Bee,

    /// <summary>
    /// 🪲
    /// </summary>
    [EnumMember(Value = "beetle")]
    Beetle,

    /// <summary>
    /// 🐞
    /// </summary>
    [EnumMember(Value = "lady_beetle")]
    LadyBeetle,

    /// <summary>
    /// 🦗
    /// </summary>
    [EnumMember(Value = "cricket")]
    Cricket,

    /// <summary>
    /// 🪳
    /// </summary>
    [EnumMember(Value = "cockroach")]
    Cockroach,

    /// <summary>
    /// 🕷️
    /// </summary>
    [EnumMember(Value = "spider")]
    Spider,

    /// <summary>
    /// 🕸️
    /// </summary>
    [EnumMember(Value = "spider_web")]
    SpiderWeb,

    /// <summary>
    /// 🦂
    /// </summary>
    [EnumMember(Value = "scorpion")]
    Scorpion,

    /// <summary>
    /// 🦟
    /// </summary>
    [EnumMember(Value = "mosquito")]
    Mosquito,

    /// <summary>
    /// 🪰
    /// </summary>
    [EnumMember(Value = "fly")]
    Fly,

    /// <summary>
    /// 🪱
    /// </summary>
    [EnumMember(Value = "worm")]
    Worm,

    /// <summary>
    /// 🦠
    /// </summary>
    [EnumMember(Value = "microbe")]
    Microbe,

    /// <summary>
    /// 💐
    /// </summary>
    [EnumMember(Value = "bouquet")]
    Bouquet,

    /// <summary>
    /// 🌸
    /// </summary>
    [EnumMember(Value = "cherry_blossom")]
    CherryBlossom,

    /// <summary>
    /// 💮
    /// </summary>
    [EnumMember(Value = "white_flower")]
    WhiteFlower,

    /// <summary>
    /// 🏵️
    /// </summary>
    [EnumMember(Value = "rosette")]
    Rosette,

    /// <summary>
    /// 🌹
    /// </summary>
    [EnumMember(Value = "rose")]
    Rose,

    /// <summary>
    /// 🥀
    /// </summary>
    [EnumMember(Value = "wilted_flower")]
    WiltedFlower,

    /// <summary>
    /// 🌺
    /// </summary>
    [EnumMember(Value = "hibiscus")]
    Hibiscus,

    /// <summary>
    /// 🌻
    /// </summary>
    [EnumMember(Value = "sunflower")]
    Sunflower,

    /// <summary>
    /// 🌼
    /// </summary>
    [EnumMember(Value = "blossom")]
    Blossom,

    /// <summary>
    /// 🌷
    /// </summary>
    [EnumMember(Value = "tulip")]
    Tulip,

    /// <summary>
    /// 🌱
    /// </summary>
    [EnumMember(Value = "seedling")]
    Seedling,

    /// <summary>
    /// 🪴
    /// </summary>
    [EnumMember(Value = "potted_plant")]
    PottedPlant,

    /// <summary>
    /// 🌲
    /// </summary>
    [EnumMember(Value = "evergreen_tree")]
    EvergreenTree,

    /// <summary>
    /// 🌳
    /// </summary>
    [EnumMember(Value = "deciduous_tree")]
    DeciduousTree,

    /// <summary>
    /// 🌴
    /// </summary>
    [EnumMember(Value = "palm_tree")]
    PalmTree,

    /// <summary>
    /// 🌵
    /// </summary>
    [EnumMember(Value = "cactus")]
    Cactus,

    /// <summary>
    /// 🌾
    /// </summary>
    [EnumMember(Value = "ear_of_rice")]
    EarOfRice,

    /// <summary>
    /// 🌿
    /// </summary>
    [EnumMember(Value = "herb")]
    Herb,

    /// <summary>
    /// ☘️
    /// </summary>
    [EnumMember(Value = "shamrock")]
    Shamrock,

    /// <summary>
    /// 🍀
    /// </summary>
    [EnumMember(Value = "four_leaf_clover")]
    FourLeafClover,

    /// <summary>
    /// 🍁
    /// </summary>
    [EnumMember(Value = "maple_leaf")]
    MapleLeaf,

    /// <summary>
    /// 🍂
    /// </summary>
    [EnumMember(Value = "fallen_leaf")]
    FallenLeaf,

    /// <summary>
    /// 🍃
    /// </summary>
    [EnumMember(Value = "leaves")]
    Leaves,

    /// <summary>
    /// 🍇
    /// </summary>
    [EnumMember(Value = "grapes")]
    Grapes,

    /// <summary>
    /// 🍈
    /// </summary>
    [EnumMember(Value = "melon")]
    Melon,

    /// <summary>
    /// 🍉
    /// </summary>
    [EnumMember(Value = "watermelon")]
    Watermelon,

    /// <summary>
    /// 🍊
    /// </summary>
    [EnumMember(Value = "tangerine")]
    Tangerine,

    /// <summary>
    /// 🍋
    /// </summary>
    [EnumMember(Value = "lemon")]
    Lemon,

    /// <summary>
    /// 🍌
    /// </summary>
    [EnumMember(Value = "banana")]
    Banana,

    /// <summary>
    /// 🍍
    /// </summary>
    [EnumMember(Value = "pineapple")]
    Pineapple,

    /// <summary>
    /// 🥭
    /// </summary>
    [EnumMember(Value = "mango")]
    Mango,

    /// <summary>
    /// 🍎
    /// </summary>
    [EnumMember(Value = "apple")]
    Apple,

    /// <summary>
    /// 🍏
    /// </summary>
    [EnumMember(Value = "green_apple")]
    GreenApple,

    /// <summary>
    /// 🍐
    /// </summary>
    [EnumMember(Value = "pear")]
    Pear,

    /// <summary>
    /// 🍑
    /// </summary>
    [EnumMember(Value = "peach")]
    Peach,

    /// <summary>
    /// 🍒
    /// </summary>
    [EnumMember(Value = "cherries")]
    Cherries,

    /// <summary>
    /// 🍓
    /// </summary>
    [EnumMember(Value = "strawberry")]
    Strawberry,

    /// <summary>
    /// 🫐
    /// </summary>
    [EnumMember(Value = "blueberries")]
    Blueberries,

    /// <summary>
    /// 🥝
    /// </summary>
    [EnumMember(Value = "kiwi_fruit")]
    KiwiFruit,

    /// <summary>
    /// 🍅
    /// </summary>
    [EnumMember(Value = "tomato")]
    Tomato,

    /// <summary>
    /// 🫒
    /// </summary>
    [EnumMember(Value = "olive")]
    Olive,

    /// <summary>
    /// 🥥
    /// </summary>
    [EnumMember(Value = "coconut")]
    Coconut,

    /// <summary>
    /// 🥑
    /// </summary>
    [EnumMember(Value = "avocado")]
    Avocado,

    /// <summary>
    /// 🍆
    /// </summary>
    [EnumMember(Value = "eggplant")]
    Eggplant,

    /// <summary>
    /// 🥔
    /// </summary>
    [EnumMember(Value = "potato")]
    Potato,

    /// <summary>
    /// 🥕
    /// </summary>
    [EnumMember(Value = "carrot")]
    Carrot,

    /// <summary>
    /// 🌽
    /// </summary>
    [EnumMember(Value = "corn")]
    Corn,

    /// <summary>
    /// 🌶️
    /// </summary>
    [EnumMember(Value = "hot_pepper")]
    HotPepper,

    /// <summary>
    /// 🫑
    /// </summary>
    [EnumMember(Value = "bell_pepper")]
    BellPepper,

    /// <summary>
    /// 🥒
    /// </summary>
    [EnumMember(Value = "cucumber")]
    Cucumber,

    /// <summary>
    /// 🥬
    /// </summary>
    [EnumMember(Value = "leafy_green")]
    LeafyGreen,

    /// <summary>
    /// 🥦
    /// </summary>
    [EnumMember(Value = "broccoli")]
    Broccoli,

    /// <summary>
    /// 🧄
    /// </summary>
    [EnumMember(Value = "garlic")]
    Garlic,

    /// <summary>
    /// 🧅
    /// </summary>
    [EnumMember(Value = "onion")]
    Onion,

    /// <summary>
    /// 🍄
    /// </summary>
    [EnumMember(Value = "mushroom")]
    Mushroom,

    /// <summary>
    /// 🥜
    /// </summary>
    [EnumMember(Value = "peanuts")]
    Peanuts,

    /// <summary>
    /// 🌰
    /// </summary>
    [EnumMember(Value = "chestnut")]
    Chestnut,

    /// <summary>
    /// 🍞
    /// </summary>
    [EnumMember(Value = "bread")]
    Bread,

    /// <summary>
    /// 🥐
    /// </summary>
    [EnumMember(Value = "croissant")]
    Croissant,

    /// <summary>
    /// 🥖
    /// </summary>
    [EnumMember(Value = "baguette_bread")]
    BaguetteBread,

    /// <summary>
    /// 🫓
    /// </summary>
    [EnumMember(Value = "flatbread")]
    Flatbread,

    /// <summary>
    /// 🥨
    /// </summary>
    [EnumMember(Value = "pretzel")]
    Pretzel,

    /// <summary>
    /// 🥯
    /// </summary>
    [EnumMember(Value = "bagel")]
    Bagel,

    /// <summary>
    /// 🥞
    /// </summary>
    [EnumMember(Value = "pancakes")]
    Pancakes,

    /// <summary>
    /// 🧇
    /// </summary>
    [EnumMember(Value = "waffle")]
    Waffle,

    /// <summary>
    /// 🧀
    /// </summary>
    [EnumMember(Value = "cheese")]
    Cheese,

    /// <summary>
    /// 🍖
    /// </summary>
    [EnumMember(Value = "meat_on_bone")]
    MeatOnBone,

    /// <summary>
    /// 🍗
    /// </summary>
    [EnumMember(Value = "poultry_leg")]
    PoultryLeg,

    /// <summary>
    /// 🥩
    /// </summary>
    [EnumMember(Value = "cut_of_meat")]
    CutOfMeat,

    /// <summary>
    /// 🥓
    /// </summary>
    [EnumMember(Value = "bacon")]
    Bacon,

    /// <summary>
    /// 🍔
    /// </summary>
    [EnumMember(Value = "hamburger")]
    Hamburger,

    /// <summary>
    /// 🍟
    /// </summary>
    [EnumMember(Value = "fries")]
    Fries,

    /// <summary>
    /// 🍕
    /// </summary>
    [EnumMember(Value = "pizza")]
    Pizza,

    /// <summary>
    /// 🌭
    /// </summary>
    [EnumMember(Value = "hotdog")]
    Hotdog,

    /// <summary>
    /// 🥪
    /// </summary>
    [EnumMember(Value = "sandwich")]
    Sandwich,

    /// <summary>
    /// 🌮
    /// </summary>
    [EnumMember(Value = "taco")]
    Taco,

    /// <summary>
    /// 🌯
    /// </summary>
    [EnumMember(Value = "burrito")]
    Burrito,

    /// <summary>
    /// 🫔
    /// </summary>
    [EnumMember(Value = "tamale")]
    Tamale,

    /// <summary>
    /// 🥙
    /// </summary>
    [EnumMember(Value = "stuffed_flatbread")]
    StuffedFlatbread,

    /// <summary>
    /// 🧆
    /// </summary>
    [EnumMember(Value = "falafel")]
    Falafel,

    /// <summary>
    /// 🥚
    /// </summary>
    [EnumMember(Value = "egg")]
    Egg,

    /// <summary>
    /// 🍳
    /// </summary>
    [EnumMember(Value = "fried_egg")]
    FriedEgg,

    /// <summary>
    /// 🥘
    /// </summary>
    [EnumMember(Value = "shallow_pan_of_food")]
    ShallowPanOfFood,

    /// <summary>
    /// 🍲
    /// </summary>
    [EnumMember(Value = "stew")]
    Stew,

    /// <summary>
    /// 🫕
    /// </summary>
    [EnumMember(Value = "fondue")]
    Fondue,

    /// <summary>
    /// 🥣
    /// </summary>
    [EnumMember(Value = "bowl_with_spoon")]
    BowlWithSpoon,

    /// <summary>
    /// 🥗
    /// </summary>
    [EnumMember(Value = "green_salad")]
    GreenSalad,

    /// <summary>
    /// 🍿
    /// </summary>
    [EnumMember(Value = "popcorn")]
    Popcorn,

    /// <summary>
    /// 🧈
    /// </summary>
    [EnumMember(Value = "butter")]
    Butter,

    /// <summary>
    /// 🧂
    /// </summary>
    [EnumMember(Value = "salt")]
    Salt,

    /// <summary>
    /// 🥫
    /// </summary>
    [EnumMember(Value = "canned_food")]
    CannedFood,

    /// <summary>
    /// 🍱
    /// </summary>
    [EnumMember(Value = "bento")]
    Bento,

    /// <summary>
    /// 🍘
    /// </summary>
    [EnumMember(Value = "rice_cracker")]
    RiceCracker,

    /// <summary>
    /// 🍙
    /// </summary>
    [EnumMember(Value = "rice_ball")]
    RiceBall,

    /// <summary>
    /// 🍚
    /// </summary>
    [EnumMember(Value = "rice")]
    Rice,

    /// <summary>
    /// 🍛
    /// </summary>
    [EnumMember(Value = "curry")]
    Curry,

    /// <summary>
    /// 🍜
    /// </summary>
    [EnumMember(Value = "ramen")]
    Ramen,

    /// <summary>
    /// 🍝
    /// </summary>
    [EnumMember(Value = "spaghetti")]
    Spaghetti,

    /// <summary>
    /// 🍠
    /// </summary>
    [EnumMember(Value = "sweet_potato")]
    SweetPotato,

    /// <summary>
    /// 🍢
    /// </summary>
    [EnumMember(Value = "oden")]
    Oden,

    /// <summary>
    /// 🍣
    /// </summary>
    [EnumMember(Value = "sushi")]
    Sushi,

    /// <summary>
    /// 🍤
    /// </summary>
    [EnumMember(Value = "fried_shrimp")]
    FriedShrimp,

    /// <summary>
    /// 🍥
    /// </summary>
    [EnumMember(Value = "fish_cake")]
    FishCake,

    /// <summary>
    /// 🥮
    /// </summary>
    [EnumMember(Value = "moon_cake")]
    MoonCake,

    /// <summary>
    /// 🍡
    /// </summary>
    [EnumMember(Value = "dango")]
    Dango,

    /// <summary>
    /// 🥟
    /// </summary>
    [EnumMember(Value = "dumpling")]
    Dumpling,

    /// <summary>
    /// 🥠
    /// </summary>
    [EnumMember(Value = "fortune_cookie")]
    FortuneCookie,

    /// <summary>
    /// 🥡
    /// </summary>
    [EnumMember(Value = "takeout_box")]
    TakeoutBox,

    /// <summary>
    /// 🦀
    /// </summary>
    [EnumMember(Value = "crab")]
    Crab,

    /// <summary>
    /// 🦞
    /// </summary>
    [EnumMember(Value = "lobster")]
    Lobster,

    /// <summary>
    /// 🦐
    /// </summary>
    [EnumMember(Value = "shrimp")]
    Shrimp,

    /// <summary>
    /// 🦑
    /// </summary>
    [EnumMember(Value = "squid")]
    Squid,

    /// <summary>
    /// 🦪
    /// </summary>
    [EnumMember(Value = "oyster")]
    Oyster,

    /// <summary>
    /// 🍦
    /// </summary>
    [EnumMember(Value = "icecream")]
    Icecream,

    /// <summary>
    /// 🍧
    /// </summary>
    [EnumMember(Value = "shaved_ice")]
    ShavedIce,

    /// <summary>
    /// 🍨
    /// </summary>
    [EnumMember(Value = "ice_cream")]
    IceCream,

    /// <summary>
    /// 🍩
    /// </summary>
    [EnumMember(Value = "doughnut")]
    Doughnut,

    /// <summary>
    /// 🍪
    /// </summary>
    [EnumMember(Value = "cookie")]
    Cookie,

    /// <summary>
    /// 🎂
    /// </summary>
    [EnumMember(Value = "birthday")]
    Birthday,

    /// <summary>
    /// 🍰
    /// </summary>
    [EnumMember(Value = "cake")]
    Cake,

    /// <summary>
    /// 🧁
    /// </summary>
    [EnumMember(Value = "cupcake")]
    Cupcake,

    /// <summary>
    /// 🥧
    /// </summary>
    [EnumMember(Value = "pie")]
    Pie,

    /// <summary>
    /// 🍫
    /// </summary>
    [EnumMember(Value = "chocolate_bar")]
    ChocolateBar,

    /// <summary>
    /// 🍬
    /// </summary>
    [EnumMember(Value = "candy")]
    Candy,

    /// <summary>
    /// 🍭
    /// </summary>
    [EnumMember(Value = "lollipop")]
    Lollipop,

    /// <summary>
    /// 🍮
    /// </summary>
    [EnumMember(Value = "custard")]
    Custard,

    /// <summary>
    /// 🍯
    /// </summary>
    [EnumMember(Value = "honey_pot")]
    HoneyPot,

    /// <summary>
    /// 🍼
    /// </summary>
    [EnumMember(Value = "baby_bottle")]
    BabyBottle,

    /// <summary>
    /// 🥛
    /// </summary>
    [EnumMember(Value = "milk_glass")]
    MilkGlass,

    /// <summary>
    /// ☕
    /// </summary>
    [EnumMember(Value = "coffee")]
    Coffee,

    /// <summary>
    /// 🫖
    /// </summary>
    [EnumMember(Value = "teapot")]
    Teapot,

    /// <summary>
    /// 🍵
    /// </summary>
    [EnumMember(Value = "tea")]
    Tea,

    /// <summary>
    /// 🍶
    /// </summary>
    [EnumMember(Value = "sake")]
    Sake,

    /// <summary>
    /// 🍾
    /// </summary>
    [EnumMember(Value = "champagne")]
    Champagne,

    /// <summary>
    /// 🍷
    /// </summary>
    [EnumMember(Value = "wine_glass")]
    WineGlass,

    /// <summary>
    /// 🍸
    /// </summary>
    [EnumMember(Value = "cocktail")]
    Cocktail,

    /// <summary>
    /// 🍹
    /// </summary>
    [EnumMember(Value = "tropical_drink")]
    TropicalDrink,

    /// <summary>
    /// 🍺
    /// </summary>
    [EnumMember(Value = "beer")]
    Beer,

    /// <summary>
    /// 🍻
    /// </summary>
    [EnumMember(Value = "beers")]
    Beers,

    /// <summary>
    /// 🥂
    /// </summary>
    [EnumMember(Value = "clinking_glasses")]
    ClinkingGlasses,

    /// <summary>
    /// 🥃
    /// </summary>
    [EnumMember(Value = "tumbler_glass")]
    TumblerGlass,

    /// <summary>
    /// 🥤
    /// </summary>
    [EnumMember(Value = "cup_with_straw")]
    CupWithStraw,

    /// <summary>
    /// 🧋
    /// </summary>
    [EnumMember(Value = "bubble_tea")]
    BubbleTea,

    /// <summary>
    /// 🧃
    /// </summary>
    [EnumMember(Value = "beverage_box")]
    BeverageBox,

    /// <summary>
    /// 🧉
    /// </summary>
    [EnumMember(Value = "mate")]
    Mate,

    /// <summary>
    /// 🧊
    /// </summary>
    [EnumMember(Value = "ice_cube")]
    IceCube,

    /// <summary>
    /// 🥢
    /// </summary>
    [EnumMember(Value = "chopsticks")]
    Chopsticks,

    /// <summary>
    /// 🍽️
    /// </summary>
    [EnumMember(Value = "plate_with_cutlery")]
    PlateWithCutlery,

    /// <summary>
    /// 🍴
    /// </summary>
    [EnumMember(Value = "fork_and_knife")]
    ForkAndKnife,

    /// <summary>
    /// 🥄
    /// </summary>
    [EnumMember(Value = "spoon")]
    Spoon,

    /// <summary>
    /// 🔪
    /// </summary>
    [EnumMember(Value = "hocho")]
    Hocho,

    /// <summary>
    /// 🏺
    /// </summary>
    [EnumMember(Value = "amphora")]
    Amphora,

    /// <summary>
    /// 🌍
    /// </summary>
    [EnumMember(Value = "earth_africa")]
    EarthAfrica,

    /// <summary>
    /// 🌎
    /// </summary>
    [EnumMember(Value = "earth_americas")]
    EarthAmericas,

    /// <summary>
    /// 🌏
    /// </summary>
    [EnumMember(Value = "earth_asia")]
    EarthAsia,

    /// <summary>
    /// 🌐
    /// </summary>
    [EnumMember(Value = "globe_with_meridians")]
    GlobeWithMeridians,

    /// <summary>
    /// 🗺️
    /// </summary>
    [EnumMember(Value = "world_map")]
    WorldMap,

    /// <summary>
    /// 🗾
    /// </summary>
    [EnumMember(Value = "japan")]
    Japan,

    /// <summary>
    /// 🧭
    /// </summary>
    [EnumMember(Value = "compass")]
    Compass,

    /// <summary>
    /// 🏔️
    /// </summary>
    [EnumMember(Value = "mountain_snow")]
    MountainSnow,

    /// <summary>
    /// ⛰️
    /// </summary>
    [EnumMember(Value = "mountain")]
    Mountain,

    /// <summary>
    /// 🌋
    /// </summary>
    [EnumMember(Value = "volcano")]
    Volcano,

    /// <summary>
    /// 🗻
    /// </summary>
    [EnumMember(Value = "mount_fuji")]
    MountFuji,

    /// <summary>
    /// 🏕️
    /// </summary>
    [EnumMember(Value = "camping")]
    Camping,

    /// <summary>
    /// 🏖️
    /// </summary>
    [EnumMember(Value = "beach_umbrella")]
    BeachUmbrella,

    /// <summary>
    /// 🏜️
    /// </summary>
    [EnumMember(Value = "desert")]
    Desert,

    /// <summary>
    /// 🏝️
    /// </summary>
    [EnumMember(Value = "desert_island")]
    DesertIsland,

    /// <summary>
    /// 🏞️
    /// </summary>
    [EnumMember(Value = "national_park")]
    NationalPark,

    /// <summary>
    /// 🏟️
    /// </summary>
    [EnumMember(Value = "stadium")]
    Stadium,

    /// <summary>
    /// 🏛️
    /// </summary>
    [EnumMember(Value = "classical_building")]
    ClassicalBuilding,

    /// <summary>
    /// 🏗️
    /// </summary>
    [EnumMember(Value = "building_construction")]
    BuildingConstruction,

    /// <summary>
    /// 🧱
    /// </summary>
    [EnumMember(Value = "bricks")]
    Bricks,

    /// <summary>
    /// 🪨
    /// </summary>
    [EnumMember(Value = "rock")]
    Rock,

    /// <summary>
    /// 🪵
    /// </summary>
    [EnumMember(Value = "wood")]
    Wood,

    /// <summary>
    /// 🛖
    /// </summary>
    [EnumMember(Value = "hut")]
    Hut,

    /// <summary>
    /// 🏘️
    /// </summary>
    [EnumMember(Value = "houses")]
    Houses,

    /// <summary>
    /// 🏚️
    /// </summary>
    [EnumMember(Value = "derelict_house")]
    DerelictHouse,

    /// <summary>
    /// 🏠
    /// </summary>
    [EnumMember(Value = "house")]
    House,

    /// <summary>
    /// 🏡
    /// </summary>
    [EnumMember(Value = "house_with_garden")]
    HouseWithGarden,

    /// <summary>
    /// 🏢
    /// </summary>
    [EnumMember(Value = "office")]
    Office,

    /// <summary>
    /// 🏣
    /// </summary>
    [EnumMember(Value = "post_office")]
    PostOffice,

    /// <summary>
    /// 🏤
    /// </summary>
    [EnumMember(Value = "european_post_office")]
    EuropeanPostOffice,

    /// <summary>
    /// 🏥
    /// </summary>
    [EnumMember(Value = "hospital")]
    Hospital,

    /// <summary>
    /// 🏦
    /// </summary>
    [EnumMember(Value = "bank")]
    Bank,

    /// <summary>
    /// 🏨
    /// </summary>
    [EnumMember(Value = "hotel")]
    Hotel,

    /// <summary>
    /// 🏩
    /// </summary>
    [EnumMember(Value = "love_hotel")]
    LoveHotel,

    /// <summary>
    /// 🏪
    /// </summary>
    [EnumMember(Value = "convenience_store")]
    ConvenienceStore,

    /// <summary>
    /// 🏫
    /// </summary>
    [EnumMember(Value = "school")]
    School,

    /// <summary>
    /// 🏬
    /// </summary>
    [EnumMember(Value = "department_store")]
    DepartmentStore,

    /// <summary>
    /// 🏭
    /// </summary>
    [EnumMember(Value = "factory")]
    Factory,

    /// <summary>
    /// 🏯
    /// </summary>
    [EnumMember(Value = "japanese_castle")]
    JapaneseCastle,

    /// <summary>
    /// 🏰
    /// </summary>
    [EnumMember(Value = "european_castle")]
    EuropeanCastle,

    /// <summary>
    /// 💒
    /// </summary>
    [EnumMember(Value = "wedding")]
    Wedding,

    /// <summary>
    /// 🗼
    /// </summary>
    [EnumMember(Value = "tokyo_tower")]
    TokyoTower,

    /// <summary>
    /// 🗽
    /// </summary>
    [EnumMember(Value = "statue_of_liberty")]
    StatueOfLiberty,

    /// <summary>
    /// ⛪
    /// </summary>
    [EnumMember(Value = "church")]
    Church,

    /// <summary>
    /// 🕌
    /// </summary>
    [EnumMember(Value = "mosque")]
    Mosque,

    /// <summary>
    /// 🛕
    /// </summary>
    [EnumMember(Value = "hindu_temple")]
    HinduTemple,

    /// <summary>
    /// 🕍
    /// </summary>
    [EnumMember(Value = "synagogue")]
    Synagogue,

    /// <summary>
    /// ⛩️
    /// </summary>
    [EnumMember(Value = "shinto_shrine")]
    ShintoShrine,

    /// <summary>
    /// 🕋
    /// </summary>
    [EnumMember(Value = "kaaba")]
    Kaaba,

    /// <summary>
    /// ⛲
    /// </summary>
    [EnumMember(Value = "fountain")]
    Fountain,

    /// <summary>
    /// ⛺
    /// </summary>
    [EnumMember(Value = "tent")]
    Tent,

    /// <summary>
    /// 🌁
    /// </summary>
    [EnumMember(Value = "foggy")]
    Foggy,

    /// <summary>
    /// 🌃
    /// </summary>
    [EnumMember(Value = "night_with_stars")]
    NightWithStars,

    /// <summary>
    /// 🏙️
    /// </summary>
    [EnumMember(Value = "cityscape")]
    Cityscape,

    /// <summary>
    /// 🌄
    /// </summary>
    [EnumMember(Value = "sunrise_over_mountains")]
    SunriseOverMountains,

    /// <summary>
    /// 🌅
    /// </summary>
    [EnumMember(Value = "sunrise")]
    Sunrise,

    /// <summary>
    /// 🌆
    /// </summary>
    [EnumMember(Value = "city_sunset")]
    CitySunset,

    /// <summary>
    /// 🌇
    /// </summary>
    [EnumMember(Value = "city_sunrise")]
    CitySunrise,

    /// <summary>
    /// 🌉
    /// </summary>
    [EnumMember(Value = "bridge_at_night")]
    BridgeAtNight,

    /// <summary>
    /// ♨️
    /// </summary>
    [EnumMember(Value = "hotsprings")]
    Hotsprings,

    /// <summary>
    /// 🎠
    /// </summary>
    [EnumMember(Value = "carousel_horse")]
    CarouselHorse,

    /// <summary>
    /// 🎡
    /// </summary>
    [EnumMember(Value = "ferris_wheel")]
    FerrisWheel,

    /// <summary>
    /// 🎢
    /// </summary>
    [EnumMember(Value = "roller_coaster")]
    RollerCoaster,

    /// <summary>
    /// 💈
    /// </summary>
    [EnumMember(Value = "barber")]
    Barber,

    /// <summary>
    /// 🎪
    /// </summary>
    [EnumMember(Value = "circus_tent")]
    CircusTent,

    /// <summary>
    /// 🚂
    /// </summary>
    [EnumMember(Value = "steam_locomotive")]
    SteamLocomotive,

    /// <summary>
    /// 🚃
    /// </summary>
    [EnumMember(Value = "railway_car")]
    RailwayCar,

    /// <summary>
    /// 🚄
    /// </summary>
    [EnumMember(Value = "bullettrain_side")]
    BullettrainSide,

    /// <summary>
    /// 🚅
    /// </summary>
    [EnumMember(Value = "bullettrain_front")]
    BullettrainFront,

    /// <summary>
    /// 🚆
    /// </summary>
    [EnumMember(Value = "train2")]
    Train2,

    /// <summary>
    /// 🚇
    /// </summary>
    [EnumMember(Value = "metro")]
    Metro,

    /// <summary>
    /// 🚈
    /// </summary>
    [EnumMember(Value = "light_rail")]
    LightRail,

    /// <summary>
    /// 🚉
    /// </summary>
    [EnumMember(Value = "station")]
    Station,

    /// <summary>
    /// 🚊
    /// </summary>
    [EnumMember(Value = "tram")]
    Tram,

    /// <summary>
    /// 🚝
    /// </summary>
    [EnumMember(Value = "monorail")]
    Monorail,

    /// <summary>
    /// 🚞
    /// </summary>
    [EnumMember(Value = "mountain_railway")]
    MountainRailway,

    /// <summary>
    /// 🚋
    /// </summary>
    [EnumMember(Value = "train")]
    Train,

    /// <summary>
    /// 🚌
    /// </summary>
    [EnumMember(Value = "bus")]
    Bus,

    /// <summary>
    /// 🚍
    /// </summary>
    [EnumMember(Value = "oncoming_bus")]
    OncomingBus,

    /// <summary>
    /// 🚎
    /// </summary>
    [EnumMember(Value = "trolleybus")]
    Trolleybus,

    /// <summary>
    /// 🚐
    /// </summary>
    [EnumMember(Value = "minibus")]
    Minibus,

    /// <summary>
    /// 🚑
    /// </summary>
    [EnumMember(Value = "ambulance")]
    Ambulance,

    /// <summary>
    /// 🚒
    /// </summary>
    [EnumMember(Value = "fire_engine")]
    FireEngine,

    /// <summary>
    /// 🚓
    /// </summary>
    [EnumMember(Value = "police_car")]
    PoliceCar,

    /// <summary>
    /// 🚔
    /// </summary>
    [EnumMember(Value = "oncoming_police_car")]
    OncomingPoliceCar,

    /// <summary>
    /// 🚕
    /// </summary>
    [EnumMember(Value = "taxi")]
    Taxi,

    /// <summary>
    /// 🚖
    /// </summary>
    [EnumMember(Value = "oncoming_taxi")]
    OncomingTaxi,

    /// <summary>
    /// 🚗
    /// </summary>
    [EnumMember(Value = "car")]
    Car,

    /// <summary>
    /// 🚘
    /// </summary>
    [EnumMember(Value = "oncoming_automobile")]
    OncomingAutomobile,

    /// <summary>
    /// 🚙
    /// </summary>
    [EnumMember(Value = "blue_car")]
    BlueCar,

    /// <summary>
    /// 🛻
    /// </summary>
    [EnumMember(Value = "pickup_truck")]
    PickupTruck,

    /// <summary>
    /// 🚚
    /// </summary>
    [EnumMember(Value = "truck")]
    Truck,

    /// <summary>
    /// 🚛
    /// </summary>
    [EnumMember(Value = "articulated_lorry")]
    ArticulatedLorry,

    /// <summary>
    /// 🚜
    /// </summary>
    [EnumMember(Value = "tractor")]
    Tractor,

    /// <summary>
    /// 🏎️
    /// </summary>
    [EnumMember(Value = "racing_car")]
    RacingCar,

    /// <summary>
    /// 🏍️
    /// </summary>
    [EnumMember(Value = "motorcycle")]
    Motorcycle,

    /// <summary>
    /// 🛵
    /// </summary>
    [EnumMember(Value = "motor_scooter")]
    MotorScooter,

    /// <summary>
    /// 🦽
    /// </summary>
    [EnumMember(Value = "manual_wheelchair")]
    ManualWheelchair,

    /// <summary>
    /// 🦼
    /// </summary>
    [EnumMember(Value = "motorized_wheelchair")]
    MotorizedWheelchair,

    /// <summary>
    /// 🛺
    /// </summary>
    [EnumMember(Value = "auto_rickshaw")]
    AutoRickshaw,

    /// <summary>
    /// 🚲
    /// </summary>
    [EnumMember(Value = "bike")]
    Bike,

    /// <summary>
    /// 🛴
    /// </summary>
    [EnumMember(Value = "kick_scooter")]
    KickScooter,

    /// <summary>
    /// 🛹
    /// </summary>
    [EnumMember(Value = "skateboard")]
    Skateboard,

    /// <summary>
    /// 🛼
    /// </summary>
    [EnumMember(Value = "roller_skate")]
    RollerSkate,

    /// <summary>
    /// 🚏
    /// </summary>
    [EnumMember(Value = "busstop")]
    Busstop,

    /// <summary>
    /// 🛣️
    /// </summary>
    [EnumMember(Value = "motorway")]
    Motorway,

    /// <summary>
    /// 🛤️
    /// </summary>
    [EnumMember(Value = "railway_track")]
    RailwayTrack,

    /// <summary>
    /// 🛢️
    /// </summary>
    [EnumMember(Value = "oil_drum")]
    OilDrum,

    /// <summary>
    /// ⛽
    /// </summary>
    [EnumMember(Value = "fuelpump")]
    Fuelpump,

    /// <summary>
    /// 🚨
    /// </summary>
    [EnumMember(Value = "rotating_light")]
    RotatingLight,

    /// <summary>
    /// 🚥
    /// </summary>
    [EnumMember(Value = "traffic_light")]
    TrafficLight,

    /// <summary>
    /// 🚦
    /// </summary>
    [EnumMember(Value = "vertical_traffic_light")]
    VerticalTrafficLight,

    /// <summary>
    /// 🛑
    /// </summary>
    [EnumMember(Value = "stop_sign")]
    StopSign,

    /// <summary>
    /// 🚧
    /// </summary>
    [EnumMember(Value = "construction")]
    Construction,

    /// <summary>
    /// ⚓
    /// </summary>
    [EnumMember(Value = "anchor")]
    Anchor,

    /// <summary>
    /// ⛵
    /// </summary>
    [EnumMember(Value = "boat")]
    Boat,

    /// <summary>
    /// 🛶
    /// </summary>
    [EnumMember(Value = "canoe")]
    Canoe,

    /// <summary>
    /// 🚤
    /// </summary>
    [EnumMember(Value = "speedboat")]
    Speedboat,

    /// <summary>
    /// 🛳️
    /// </summary>
    [EnumMember(Value = "passenger_ship")]
    PassengerShip,

    /// <summary>
    /// ⛴️
    /// </summary>
    [EnumMember(Value = "ferry")]
    Ferry,

    /// <summary>
    /// 🛥️
    /// </summary>
    [EnumMember(Value = "motor_boat")]
    MotorBoat,

    /// <summary>
    /// 🚢
    /// </summary>
    [EnumMember(Value = "ship")]
    Ship,

    /// <summary>
    /// ✈️
    /// </summary>
    [EnumMember(Value = "airplane")]
    Airplane,

    /// <summary>
    /// 🛩️
    /// </summary>
    [EnumMember(Value = "small_airplane")]
    SmallAirplane,

    /// <summary>
    /// 🛫
    /// </summary>
    [EnumMember(Value = "flight_departure")]
    FlightDeparture,

    /// <summary>
    /// 🛬
    /// </summary>
    [EnumMember(Value = "flight_arrival")]
    FlightArrival,

    /// <summary>
    /// 🪂
    /// </summary>
    [EnumMember(Value = "parachute")]
    Parachute,

    /// <summary>
    /// 💺
    /// </summary>
    [EnumMember(Value = "seat")]
    Seat,

    /// <summary>
    /// 🚁
    /// </summary>
    [EnumMember(Value = "helicopter")]
    Helicopter,

    /// <summary>
    /// 🚟
    /// </summary>
    [EnumMember(Value = "suspension_railway")]
    SuspensionRailway,

    /// <summary>
    /// 🚠
    /// </summary>
    [EnumMember(Value = "mountain_cableway")]
    MountainCableway,

    /// <summary>
    /// 🚡
    /// </summary>
    [EnumMember(Value = "aerial_tramway")]
    AerialTramway,

    /// <summary>
    /// 🛰️
    /// </summary>
    [EnumMember(Value = "artificial_satellite")]
    ArtificialSatellite,

    /// <summary>
    /// 🚀
    /// </summary>
    [EnumMember(Value = "rocket")]
    Rocket,

    /// <summary>
    /// 🛸
    /// </summary>
    [EnumMember(Value = "flying_saucer")]
    FlyingSaucer,

    /// <summary>
    /// 🛎️
    /// </summary>
    [EnumMember(Value = "bellhop_bell")]
    BellhopBell,

    /// <summary>
    /// 🧳
    /// </summary>
    [EnumMember(Value = "luggage")]
    Luggage,

    /// <summary>
    /// ⌛
    /// </summary>
    [EnumMember(Value = "hourglass")]
    Hourglass,

    /// <summary>
    /// ⏳
    /// </summary>
    [EnumMember(Value = "hourglass_flowing_sand")]
    HourglassFlowingSand,

    /// <summary>
    /// ⌚
    /// </summary>
    [EnumMember(Value = "watch")]
    Watch,

    /// <summary>
    /// ⏰
    /// </summary>
    [EnumMember(Value = "alarm_clock")]
    AlarmClock,

    /// <summary>
    /// ⏱️
    /// </summary>
    [EnumMember(Value = "stopwatch")]
    Stopwatch,

    /// <summary>
    /// ⏲️
    /// </summary>
    [EnumMember(Value = "timer_clock")]
    TimerClock,

    /// <summary>
    /// 🕰️
    /// </summary>
    [EnumMember(Value = "mantelpiece_clock")]
    MantelpieceClock,

    /// <summary>
    /// 🕛
    /// </summary>
    [EnumMember(Value = "clock12")]
    Clock12,

    /// <summary>
    /// 🕧
    /// </summary>
    [EnumMember(Value = "clock1230")]
    Clock1230,

    /// <summary>
    /// 🕐
    /// </summary>
    [EnumMember(Value = "clock1")]
    Clock1,

    /// <summary>
    /// 🕜
    /// </summary>
    [EnumMember(Value = "clock130")]
    Clock130,

    /// <summary>
    /// 🕑
    /// </summary>
    [EnumMember(Value = "clock2")]
    Clock2,

    /// <summary>
    /// 🕝
    /// </summary>
    [EnumMember(Value = "clock230")]
    Clock230,

    /// <summary>
    /// 🕒
    /// </summary>
    [EnumMember(Value = "clock3")]
    Clock3,

    /// <summary>
    /// 🕞
    /// </summary>
    [EnumMember(Value = "clock330")]
    Clock330,

    /// <summary>
    /// 🕓
    /// </summary>
    [EnumMember(Value = "clock4")]
    Clock4,

    /// <summary>
    /// 🕟
    /// </summary>
    [EnumMember(Value = "clock430")]
    Clock430,

    /// <summary>
    /// 🕔
    /// </summary>
    [EnumMember(Value = "clock5")]
    Clock5,

    /// <summary>
    /// 🕠
    /// </summary>
    [EnumMember(Value = "clock530")]
    Clock530,

    /// <summary>
    /// 🕕
    /// </summary>
    [EnumMember(Value = "clock6")]
    Clock6,

    /// <summary>
    /// 🕡
    /// </summary>
    [EnumMember(Value = "clock630")]
    Clock630,

    /// <summary>
    /// 🕖
    /// </summary>
    [EnumMember(Value = "clock7")]
    Clock7,

    /// <summary>
    /// 🕢
    /// </summary>
    [EnumMember(Value = "clock730")]
    Clock730,

    /// <summary>
    /// 🕗
    /// </summary>
    [EnumMember(Value = "clock8")]
    Clock8,

    /// <summary>
    /// 🕣
    /// </summary>
    [EnumMember(Value = "clock830")]
    Clock830,

    /// <summary>
    /// 🕘
    /// </summary>
    [EnumMember(Value = "clock9")]
    Clock9,

    /// <summary>
    /// 🕤
    /// </summary>
    [EnumMember(Value = "clock930")]
    Clock930,

    /// <summary>
    /// 🕙
    /// </summary>
    [EnumMember(Value = "clock10")]
    Clock10,

    /// <summary>
    /// 🕥
    /// </summary>
    [EnumMember(Value = "clock1030")]
    Clock1030,

    /// <summary>
    /// 🕚
    /// </summary>
    [EnumMember(Value = "clock11")]
    Clock11,

    /// <summary>
    /// 🕦
    /// </summary>
    [EnumMember(Value = "clock1130")]
    Clock1130,

    /// <summary>
    /// 🌑
    /// </summary>
    [EnumMember(Value = "new_moon")]
    NewMoon,

    /// <summary>
    /// 🌒
    /// </summary>
    [EnumMember(Value = "waxing_crescent_moon")]
    WaxingCrescentMoon,

    /// <summary>
    /// 🌓
    /// </summary>
    [EnumMember(Value = "first_quarter_moon")]
    FirstQuarterMoon,

    /// <summary>
    /// 🌔
    /// </summary>
    [EnumMember(Value = "moon")]
    Moon,

    /// <summary>
    /// 🌕
    /// </summary>
    [EnumMember(Value = "full_moon")]
    FullMoon,

    /// <summary>
    /// 🌖
    /// </summary>
    [EnumMember(Value = "waning_gibbous_moon")]
    WaningGibbousMoon,

    /// <summary>
    /// 🌗
    /// </summary>
    [EnumMember(Value = "last_quarter_moon")]
    LastQuarterMoon,

    /// <summary>
    /// 🌘
    /// </summary>
    [EnumMember(Value = "waning_crescent_moon")]
    WaningCrescentMoon,

    /// <summary>
    /// 🌙
    /// </summary>
    [EnumMember(Value = "crescent_moon")]
    CrescentMoon,

    /// <summary>
    /// 🌚
    /// </summary>
    [EnumMember(Value = "new_moon_with_face")]
    NewMoonWithFace,

    /// <summary>
    /// 🌛
    /// </summary>
    [EnumMember(Value = "first_quarter_moon_with_face")]
    FirstQuarterMoonWithFace,

    /// <summary>
    /// 🌜
    /// </summary>
    [EnumMember(Value = "last_quarter_moon_with_face")]
    LastQuarterMoonWithFace,

    /// <summary>
    /// 🌡️
    /// </summary>
    [EnumMember(Value = "thermometer")]
    Thermometer,

    /// <summary>
    /// ☀️
    /// </summary>
    [EnumMember(Value = "sunny")]
    Sunny,

    /// <summary>
    /// 🌝
    /// </summary>
    [EnumMember(Value = "full_moon_with_face")]
    FullMoonWithFace,

    /// <summary>
    /// 🌞
    /// </summary>
    [EnumMember(Value = "sun_with_face")]
    SunWithFace,

    /// <summary>
    /// 🪐
    /// </summary>
    [EnumMember(Value = "ringed_planet")]
    RingedPlanet,

    /// <summary>
    /// ⭐
    /// </summary>
    [EnumMember(Value = "star")]
    Star,

    /// <summary>
    /// 🌟
    /// </summary>
    [EnumMember(Value = "star2")]
    Star2,

    /// <summary>
    /// 🌠
    /// </summary>
    [EnumMember(Value = "stars")]
    Stars,

    /// <summary>
    /// 🌌
    /// </summary>
    [EnumMember(Value = "milky_way")]
    MilkyWay,

    /// <summary>
    /// ☁️
    /// </summary>
    [EnumMember(Value = "cloud")]
    Cloud,

    /// <summary>
    /// ⛅
    /// </summary>
    [EnumMember(Value = "partly_sunny")]
    PartlySunny,

    /// <summary>
    /// ⛈️
    /// </summary>
    [EnumMember(Value = "cloud_with_lightning_and_rain")]
    CloudWithLightningAndRain,

    /// <summary>
    /// 🌤️
    /// </summary>
    [EnumMember(Value = "sun_behind_small_cloud")]
    SunBehindSmallCloud,

    /// <summary>
    /// 🌥️
    /// </summary>
    [EnumMember(Value = "sun_behind_large_cloud")]
    SunBehindLargeCloud,

    /// <summary>
    /// 🌦️
    /// </summary>
    [EnumMember(Value = "sun_behind_rain_cloud")]
    SunBehindRainCloud,

    /// <summary>
    /// 🌧️
    /// </summary>
    [EnumMember(Value = "cloud_with_rain")]
    CloudWithRain,

    /// <summary>
    /// 🌨️
    /// </summary>
    [EnumMember(Value = "cloud_with_snow")]
    CloudWithSnow,

    /// <summary>
    /// 🌩️
    /// </summary>
    [EnumMember(Value = "cloud_with_lightning")]
    CloudWithLightning,

    /// <summary>
    /// 🌪️
    /// </summary>
    [EnumMember(Value = "tornado")]
    Tornado,

    /// <summary>
    /// 🌫️
    /// </summary>
    [EnumMember(Value = "fog")]
    Fog,

    /// <summary>
    /// 🌬️
    /// </summary>
    [EnumMember(Value = "wind_face")]
    WindFace,

    /// <summary>
    /// 🌀
    /// </summary>
    [EnumMember(Value = "cyclone")]
    Cyclone,

    /// <summary>
    /// 🌈
    /// </summary>
    [EnumMember(Value = "rainbow")]
    Rainbow,

    /// <summary>
    /// 🌂
    /// </summary>
    [EnumMember(Value = "closed_umbrella")]
    ClosedUmbrella,

    /// <summary>
    /// ☂️
    /// </summary>
    [EnumMember(Value = "open_umbrella")]
    OpenUmbrella,

    /// <summary>
    /// ☔
    /// </summary>
    [EnumMember(Value = "umbrella")]
    Umbrella,

    /// <summary>
    /// ⛱️
    /// </summary>
    [EnumMember(Value = "parasol_on_ground")]
    ParasolOnGround,

    /// <summary>
    /// ⚡
    /// </summary>
    [EnumMember(Value = "zap")]
    Zap,

    /// <summary>
    /// ❄️
    /// </summary>
    [EnumMember(Value = "snowflake")]
    Snowflake,

    /// <summary>
    /// ☃️
    /// </summary>
    [EnumMember(Value = "snowman_with_snow")]
    SnowmanWithSnow,

    /// <summary>
    /// ⛄
    /// </summary>
    [EnumMember(Value = "snowman")]
    Snowman,

    /// <summary>
    /// ☄️
    /// </summary>
    [EnumMember(Value = "comet")]
    Comet,

    /// <summary>
    /// 🔥
    /// </summary>
    [EnumMember(Value = "fire")]
    Fire,

    /// <summary>
    /// 💧
    /// </summary>
    [EnumMember(Value = "droplet")]
    Droplet,

    /// <summary>
    /// 🌊
    /// </summary>
    [EnumMember(Value = "ocean")]
    Ocean,

    /// <summary>
    /// 🎃
    /// </summary>
    [EnumMember(Value = "jack_o_lantern")]
    JackOLantern,

    /// <summary>
    /// 🎄
    /// </summary>
    [EnumMember(Value = "christmas_tree")]
    ChristmasTree,

    /// <summary>
    /// 🎆
    /// </summary>
    [EnumMember(Value = "fireworks")]
    Fireworks,

    /// <summary>
    /// 🎇
    /// </summary>
    [EnumMember(Value = "sparkler")]
    Sparkler,

    /// <summary>
    /// 🧨
    /// </summary>
    [EnumMember(Value = "firecracker")]
    Firecracker,

    /// <summary>
    /// ✨
    /// </summary>
    [EnumMember(Value = "sparkles")]
    Sparkles,

    /// <summary>
    /// 🎈
    /// </summary>
    [EnumMember(Value = "balloon")]
    Balloon,

    /// <summary>
    /// 🎉
    /// </summary>
    [EnumMember(Value = "tada")]
    Tada,

    /// <summary>
    /// 🎊
    /// </summary>
    [EnumMember(Value = "confetti_ball")]
    ConfettiBall,

    /// <summary>
    /// 🎋
    /// </summary>
    [EnumMember(Value = "tanabata_tree")]
    TanabataTree,

    /// <summary>
    /// 🎍
    /// </summary>
    [EnumMember(Value = "bamboo")]
    Bamboo,

    /// <summary>
    /// 🎎
    /// </summary>
    [EnumMember(Value = "dolls")]
    Dolls,

    /// <summary>
    /// 🎏
    /// </summary>
    [EnumMember(Value = "flags")]
    Flags,

    /// <summary>
    /// 🎐
    /// </summary>
    [EnumMember(Value = "wind_chime")]
    WindChime,

    /// <summary>
    /// 🎑
    /// </summary>
    [EnumMember(Value = "rice_scene")]
    RiceScene,

    /// <summary>
    /// 🧧
    /// </summary>
    [EnumMember(Value = "red_envelope")]
    RedEnvelope,

    /// <summary>
    /// 🎀
    /// </summary>
    [EnumMember(Value = "ribbon")]
    Ribbon,

    /// <summary>
    /// 🎁
    /// </summary>
    [EnumMember(Value = "gift")]
    Gift,

    /// <summary>
    /// 🎗️
    /// </summary>
    [EnumMember(Value = "reminder_ribbon")]
    ReminderRibbon,

    /// <summary>
    /// 🎟️
    /// </summary>
    [EnumMember(Value = "tickets")]
    Tickets,

    /// <summary>
    /// 🎫
    /// </summary>
    [EnumMember(Value = "ticket")]
    Ticket,

    /// <summary>
    /// 🎖️
    /// </summary>
    [EnumMember(Value = "medal_military")]
    MedalMilitary,

    /// <summary>
    /// 🏆
    /// </summary>
    [EnumMember(Value = "trophy")]
    Trophy,

    /// <summary>
    /// 🏅
    /// </summary>
    [EnumMember(Value = "medal_sports")]
    MedalSports,

    /// <summary>
    /// 🥇
    /// </summary>
    [EnumMember(Value = "1st_place_medal")]
    FirstPlaceMedal,

    /// <summary>
    /// 🥈
    /// </summary>
    [EnumMember(Value = "2nd_place_medal")]
    SecondPlaceMedal,

    /// <summary>
    /// 🥉
    /// </summary>
    [EnumMember(Value = "3rd_place_medal")]
    ThirdPlaceMedal,

    /// <summary>
    /// ⚽
    /// </summary>
    [EnumMember(Value = "soccer")]
    Soccer,

    /// <summary>
    /// ⚾
    /// </summary>
    [EnumMember(Value = "baseball")]
    Baseball,

    /// <summary>
    /// 🥎
    /// </summary>
    [EnumMember(Value = "softball")]
    Softball,

    /// <summary>
    /// 🏀
    /// </summary>
    [EnumMember(Value = "basketball")]
    Basketball,

    /// <summary>
    /// 🏐
    /// </summary>
    [EnumMember(Value = "volleyball")]
    Volleyball,

    /// <summary>
    /// 🏈
    /// </summary>
    [EnumMember(Value = "football")]
    Football,

    /// <summary>
    /// 🏉
    /// </summary>
    [EnumMember(Value = "rugby_football")]
    RugbyFootball,

    /// <summary>
    /// 🎾
    /// </summary>
    [EnumMember(Value = "tennis")]
    Tennis,

    /// <summary>
    /// 🥏
    /// </summary>
    [EnumMember(Value = "flying_disc")]
    FlyingDisc,

    /// <summary>
    /// 🎳
    /// </summary>
    [EnumMember(Value = "bowling")]
    Bowling,

    /// <summary>
    /// 🏏
    /// </summary>
    [EnumMember(Value = "cricket_game")]
    CricketGame,

    /// <summary>
    /// 🏑
    /// </summary>
    [EnumMember(Value = "field_hockey")]
    FieldHockey,

    /// <summary>
    /// 🏒
    /// </summary>
    [EnumMember(Value = "ice_hockey")]
    IceHockey,

    /// <summary>
    /// 🥍
    /// </summary>
    [EnumMember(Value = "lacrosse")]
    Lacrosse,

    /// <summary>
    /// 🏓
    /// </summary>
    [EnumMember(Value = "ping_pong")]
    PingPong,

    /// <summary>
    /// 🏸
    /// </summary>
    [EnumMember(Value = "badminton")]
    Badminton,

    /// <summary>
    /// 🥊
    /// </summary>
    [EnumMember(Value = "boxing_glove")]
    BoxingGlove,

    /// <summary>
    /// 🥋
    /// </summary>
    [EnumMember(Value = "martial_arts_uniform")]
    MartialArtsUniform,

    /// <summary>
    /// 🥅
    /// </summary>
    [EnumMember(Value = "goal_net")]
    GoalNet,

    /// <summary>
    /// ⛳
    /// </summary>
    [EnumMember(Value = "golf")]
    Golf,

    /// <summary>
    /// ⛸️
    /// </summary>
    [EnumMember(Value = "ice_skate")]
    IceSkate,

    /// <summary>
    /// 🎣
    /// </summary>
    [EnumMember(Value = "fishing_pole_and_fish")]
    FishingPoleAndFish,

    /// <summary>
    /// 🤿
    /// </summary>
    [EnumMember(Value = "diving_mask")]
    DivingMask,

    /// <summary>
    /// 🎽
    /// </summary>
    [EnumMember(Value = "running_shirt_with_sash")]
    RunningShirtWithSash,

    /// <summary>
    /// 🎿
    /// </summary>
    [EnumMember(Value = "ski")]
    Ski,

    /// <summary>
    /// 🛷
    /// </summary>
    [EnumMember(Value = "sled")]
    Sled,

    /// <summary>
    /// 🥌
    /// </summary>
    [EnumMember(Value = "curling_stone")]
    CurlingStone,

    /// <summary>
    /// 🎯
    /// </summary>
    [EnumMember(Value = "dart")]
    Dart,

    /// <summary>
    /// 🪀
    /// </summary>
    [EnumMember(Value = "yo_yo")]
    YoYo,

    /// <summary>
    /// 🪁
    /// </summary>
    [EnumMember(Value = "kite")]
    Kite,

    /// <summary>
    /// 🎱
    /// </summary>
    [EnumMember(Value = "8ball")]
    EightBall,

    /// <summary>
    /// 🔮
    /// </summary>
    [EnumMember(Value = "crystal_ball")]
    CrystalBall,

    /// <summary>
    /// 🪄
    /// </summary>
    [EnumMember(Value = "magic_wand")]
    MagicWand,

    /// <summary>
    /// 🧿
    /// </summary>
    [EnumMember(Value = "nazar_amulet")]
    NazarAmulet,

    /// <summary>
    /// 🎮
    /// </summary>
    [EnumMember(Value = "video_game")]
    VideoGame,

    /// <summary>
    /// 🕹️
    /// </summary>
    [EnumMember(Value = "joystick")]
    Joystick,

    /// <summary>
    /// 🎰
    /// </summary>
    [EnumMember(Value = "slot_machine")]
    SlotMachine,

    /// <summary>
    /// 🎲
    /// </summary>
    [EnumMember(Value = "game_die")]
    GameDie,

    /// <summary>
    /// 🧩
    /// </summary>
    [EnumMember(Value = "jigsaw")]
    Jigsaw,

    /// <summary>
    /// 🧸
    /// </summary>
    [EnumMember(Value = "teddy_bear")]
    TeddyBear,

    /// <summary>
    /// 🪅
    /// </summary>
    [EnumMember(Value = "pinata")]
    Pinata,

    /// <summary>
    /// 🪆
    /// </summary>
    [EnumMember(Value = "nesting_dolls")]
    NestingDolls,

    /// <summary>
    /// ♠️
    /// </summary>
    [EnumMember(Value = "spades")]
    Spades,

    /// <summary>
    /// ♥️
    /// </summary>
    [EnumMember(Value = "hearts")]
    Hearts,

    /// <summary>
    /// ♦️
    /// </summary>
    [EnumMember(Value = "diamonds")]
    Diamonds,

    /// <summary>
    /// ♣️
    /// </summary>
    [EnumMember(Value = "clubs")]
    Clubs,

    /// <summary>
    /// ♟️
    /// </summary>
    [EnumMember(Value = "chess_pawn")]
    ChessPawn,

    /// <summary>
    /// 🃏
    /// </summary>
    [EnumMember(Value = "black_joker")]
    BlackJoker,

    /// <summary>
    /// 🀄
    /// </summary>
    [EnumMember(Value = "mahjong")]
    Mahjong,

    /// <summary>
    /// 🎴
    /// </summary>
    [EnumMember(Value = "flower_playing_cards")]
    FlowerPlayingCards,

    /// <summary>
    /// 🎭
    /// </summary>
    [EnumMember(Value = "performing_arts")]
    PerformingArts,

    /// <summary>
    /// 🖼️
    /// </summary>
    [EnumMember(Value = "framed_picture")]
    FramedPicture,

    /// <summary>
    /// 🎨
    /// </summary>
    [EnumMember(Value = "art")]
    Art,

    /// <summary>
    /// 🧵
    /// </summary>
    [EnumMember(Value = "thread")]
    Thread,

    /// <summary>
    /// 🪡
    /// </summary>
    [EnumMember(Value = "sewing_needle")]
    SewingNeedle,

    /// <summary>
    /// 🧶
    /// </summary>
    [EnumMember(Value = "yarn")]
    Yarn,

    /// <summary>
    /// 🪢
    /// </summary>
    [EnumMember(Value = "knot")]
    Knot,

    /// <summary>
    /// 👓
    /// </summary>
    [EnumMember(Value = "eyeglasses")]
    Eyeglasses,

    /// <summary>
    /// 🕶️
    /// </summary>
    [EnumMember(Value = "dark_sunglasses")]
    DarkSunglasses,

    /// <summary>
    /// 🥽
    /// </summary>
    [EnumMember(Value = "goggles")]
    Goggles,

    /// <summary>
    /// 🥼
    /// </summary>
    [EnumMember(Value = "lab_coat")]
    LabCoat,

    /// <summary>
    /// 🦺
    /// </summary>
    [EnumMember(Value = "safety_vest")]
    SafetyVest,

    /// <summary>
    /// 👔
    /// </summary>
    [EnumMember(Value = "necktie")]
    Necktie,

    /// <summary>
    /// 👕
    /// </summary>
    [EnumMember(Value = "shirt")]
    Shirt,

    /// <summary>
    /// 👖
    /// </summary>
    [EnumMember(Value = "jeans")]
    Jeans,

    /// <summary>
    /// 🧣
    /// </summary>
    [EnumMember(Value = "scarf")]
    Scarf,

    /// <summary>
    /// 🧤
    /// </summary>
    [EnumMember(Value = "gloves")]
    Gloves,

    /// <summary>
    /// 🧥
    /// </summary>
    [EnumMember(Value = "coat")]
    Coat,

    /// <summary>
    /// 🧦
    /// </summary>
    [EnumMember(Value = "socks")]
    Socks,

    /// <summary>
    /// 👗
    /// </summary>
    [EnumMember(Value = "dress")]
    Dress,

    /// <summary>
    /// 👘
    /// </summary>
    [EnumMember(Value = "kimono")]
    Kimono,

    /// <summary>
    /// 🥻
    /// </summary>
    [EnumMember(Value = "sari")]
    Sari,

    /// <summary>
    /// 🩱
    /// </summary>
    [EnumMember(Value = "one_piece_swimsuit")]
    OnePieceSwimsuit,

    /// <summary>
    /// 🩲
    /// </summary>
    [EnumMember(Value = "swim_brief")]
    SwimBrief,

    /// <summary>
    /// 🩳
    /// </summary>
    [EnumMember(Value = "shorts")]
    Shorts,

    /// <summary>
    /// 👙
    /// </summary>
    [EnumMember(Value = "bikini")]
    Bikini,

    /// <summary>
    /// 👚
    /// </summary>
    [EnumMember(Value = "womans_clothes")]
    WomansClothes,

    /// <summary>
    /// 👛
    /// </summary>
    [EnumMember(Value = "purse")]
    Purse,

    /// <summary>
    /// 👜
    /// </summary>
    [EnumMember(Value = "handbag")]
    Handbag,

    /// <summary>
    /// 👝
    /// </summary>
    [EnumMember(Value = "pouch")]
    Pouch,

    /// <summary>
    /// 🛍️
    /// </summary>
    [EnumMember(Value = "shopping")]
    Shopping,

    /// <summary>
    /// 🎒
    /// </summary>
    [EnumMember(Value = "school_satchel")]
    SchoolSatchel,

    /// <summary>
    /// 🩴
    /// </summary>
    [EnumMember(Value = "thong_sandal")]
    ThongSandal,

    /// <summary>
    /// 👞
    /// </summary>
    [EnumMember(Value = "mans_shoe")]
    MansShoe,

    /// <summary>
    /// 👟
    /// </summary>
    [EnumMember(Value = "athletic_shoe")]
    AthleticShoe,

    /// <summary>
    /// 🥾
    /// </summary>
    [EnumMember(Value = "hiking_boot")]
    HikingBoot,

    /// <summary>
    /// 🥿
    /// </summary>
    [EnumMember(Value = "flat_shoe")]
    FlatShoe,

    /// <summary>
    /// 👠
    /// </summary>
    [EnumMember(Value = "high_heel")]
    HighHeel,

    /// <summary>
    /// 👡
    /// </summary>
    [EnumMember(Value = "sandal")]
    Sandal,

    /// <summary>
    /// 🩰
    /// </summary>
    [EnumMember(Value = "ballet_shoes")]
    BalletShoes,

    /// <summary>
    /// 👢
    /// </summary>
    [EnumMember(Value = "boot")]
    Boot,

    /// <summary>
    /// 👑
    /// </summary>
    [EnumMember(Value = "crown")]
    Crown,

    /// <summary>
    /// 👒
    /// </summary>
    [EnumMember(Value = "womans_hat")]
    WomansHat,

    /// <summary>
    /// 🎩
    /// </summary>
    [EnumMember(Value = "tophat")]
    Tophat,

    /// <summary>
    /// 🎓
    /// </summary>
    [EnumMember(Value = "mortar_board")]
    MortarBoard,

    /// <summary>
    /// 🧢
    /// </summary>
    [EnumMember(Value = "billed_cap")]
    BilledCap,

    /// <summary>
    /// 🪖
    /// </summary>
    [EnumMember(Value = "military_helmet")]
    MilitaryHelmet,

    /// <summary>
    /// ⛑️
    /// </summary>
    [EnumMember(Value = "rescue_worker_helmet")]
    RescueWorkerHelmet,

    /// <summary>
    /// 📿
    /// </summary>
    [EnumMember(Value = "prayer_beads")]
    PrayerBeads,

    /// <summary>
    /// 💄
    /// </summary>
    [EnumMember(Value = "lipstick")]
    Lipstick,

    /// <summary>
    /// 💍
    /// </summary>
    [EnumMember(Value = "ring")]
    Ring,

    /// <summary>
    /// 💎
    /// </summary>
    [EnumMember(Value = "gem")]
    Gem,

    /// <summary>
    /// 🔇
    /// </summary>
    [EnumMember(Value = "mute")]
    Mute,

    /// <summary>
    /// 🔈
    /// </summary>
    [EnumMember(Value = "speaker")]
    Speaker,

    /// <summary>
    /// 🔉
    /// </summary>
    [EnumMember(Value = "sound")]
    Sound,

    /// <summary>
    /// 🔊
    /// </summary>
    [EnumMember(Value = "loud_sound")]
    LoudSound,

    /// <summary>
    /// 📢
    /// </summary>
    [EnumMember(Value = "loudspeaker")]
    Loudspeaker,

    /// <summary>
    /// 📣
    /// </summary>
    [EnumMember(Value = "mega")]
    Mega,

    /// <summary>
    /// 📯
    /// </summary>
    [EnumMember(Value = "postal_horn")]
    PostalHorn,

    /// <summary>
    /// 🔔
    /// </summary>
    [EnumMember(Value = "bell")]
    Bell,

    /// <summary>
    /// 🔕
    /// </summary>
    [EnumMember(Value = "no_bell")]
    NoBell,

    /// <summary>
    /// 🎼
    /// </summary>
    [EnumMember(Value = "musical_score")]
    MusicalScore,

    /// <summary>
    /// 🎵
    /// </summary>
    [EnumMember(Value = "musical_note")]
    MusicalNote,

    /// <summary>
    /// 🎶
    /// </summary>
    [EnumMember(Value = "notes")]
    Notes,

    /// <summary>
    /// 🎙️
    /// </summary>
    [EnumMember(Value = "studio_microphone")]
    StudioMicrophone,

    /// <summary>
    /// 🎚️
    /// </summary>
    [EnumMember(Value = "level_slider")]
    LevelSlider,

    /// <summary>
    /// 🎛️
    /// </summary>
    [EnumMember(Value = "control_knobs")]
    ControlKnobs,

    /// <summary>
    /// 🎤
    /// </summary>
    [EnumMember(Value = "microphone")]
    Microphone,

    /// <summary>
    /// 🎧
    /// </summary>
    [EnumMember(Value = "headphones")]
    Headphones,

    /// <summary>
    /// 📻
    /// </summary>
    [EnumMember(Value = "radio")]
    Radio,

    /// <summary>
    /// 🎷
    /// </summary>
    [EnumMember(Value = "saxophone")]
    Saxophone,

    /// <summary>
    /// 🪗
    /// </summary>
    [EnumMember(Value = "accordion")]
    Accordion,

    /// <summary>
    /// 🎸
    /// </summary>
    [EnumMember(Value = "guitar")]
    Guitar,

    /// <summary>
    /// 🎹
    /// </summary>
    [EnumMember(Value = "musical_keyboard")]
    MusicalKeyboard,

    /// <summary>
    /// 🎺
    /// </summary>
    [EnumMember(Value = "trumpet")]
    Trumpet,

    /// <summary>
    /// 🎻
    /// </summary>
    [EnumMember(Value = "violin")]
    Violin,

    /// <summary>
    /// 🪕
    /// </summary>
    [EnumMember(Value = "banjo")]
    Banjo,

    /// <summary>
    /// 🥁
    /// </summary>
    [EnumMember(Value = "drum")]
    Drum,

    /// <summary>
    /// 🪘
    /// </summary>
    [EnumMember(Value = "long_drum")]
    LongDrum,

    /// <summary>
    /// 📱
    /// </summary>
    [EnumMember(Value = "iphone")]
    Iphone,

    /// <summary>
    /// 📲
    /// </summary>
    [EnumMember(Value = "calling")]
    Calling,

    /// <summary>
    /// ☎️
    /// </summary>
    [EnumMember(Value = "phone")]
    Phone,

    /// <summary>
    /// 📞
    /// </summary>
    [EnumMember(Value = "telephone_receiver")]
    TelephoneReceiver,

    /// <summary>
    /// 📟
    /// </summary>
    [EnumMember(Value = "pager")]
    Pager,

    /// <summary>
    /// 📠
    /// </summary>
    [EnumMember(Value = "fax")]
    Fax,

    /// <summary>
    /// 🔋
    /// </summary>
    [EnumMember(Value = "battery")]
    Battery,

    /// <summary>
    /// 🔌
    /// </summary>
    [EnumMember(Value = "electric_plug")]
    ElectricPlug,

    /// <summary>
    /// 💻
    /// </summary>
    [EnumMember(Value = "computer")]
    Computer,

    /// <summary>
    /// 🖥️
    /// </summary>
    [EnumMember(Value = "desktop_computer")]
    DesktopComputer,

    /// <summary>
    /// 🖨️
    /// </summary>
    [EnumMember(Value = "printer")]
    Printer,

    /// <summary>
    /// ⌨️
    /// </summary>
    [EnumMember(Value = "keyboard")]
    Keyboard,

    /// <summary>
    /// 🖱️
    /// </summary>
    [EnumMember(Value = "computer_mouse")]
    ComputerMouse,

    /// <summary>
    /// 🖲️
    /// </summary>
    [EnumMember(Value = "trackball")]
    Trackball,

    /// <summary>
    /// 💽
    /// </summary>
    [EnumMember(Value = "minidisc")]
    Minidisc,

    /// <summary>
    /// 💾
    /// </summary>
    [EnumMember(Value = "floppy_disk")]
    FloppyDisk,

    /// <summary>
    /// 💿
    /// </summary>
    [EnumMember(Value = "cd")]
    Cd,

    /// <summary>
    /// 📀
    /// </summary>
    [EnumMember(Value = "dvd")]
    Dvd,

    /// <summary>
    /// 🧮
    /// </summary>
    [EnumMember(Value = "abacus")]
    Abacus,

    /// <summary>
    /// 🎥
    /// </summary>
    [EnumMember(Value = "movie_camera")]
    MovieCamera,

    /// <summary>
    /// 🎞️
    /// </summary>
    [EnumMember(Value = "film_strip")]
    FilmStrip,

    /// <summary>
    /// 📽️
    /// </summary>
    [EnumMember(Value = "film_projector")]
    FilmProjector,

    /// <summary>
    /// 🎬
    /// </summary>
    [EnumMember(Value = "clapper")]
    Clapper,

    /// <summary>
    /// 📺
    /// </summary>
    [EnumMember(Value = "tv")]
    Tv,

    /// <summary>
    /// 📷
    /// </summary>
    [EnumMember(Value = "camera")]
    Camera,

    /// <summary>
    /// 📸
    /// </summary>
    [EnumMember(Value = "camera_flash")]
    CameraFlash,

    /// <summary>
    /// 📹
    /// </summary>
    [EnumMember(Value = "video_camera")]
    VideoCamera,

    /// <summary>
    /// 📼
    /// </summary>
    [EnumMember(Value = "vhs")]
    Vhs,

    /// <summary>
    /// 🔍
    /// </summary>
    [EnumMember(Value = "mag")]
    Mag,

    /// <summary>
    /// 🔎
    /// </summary>
    [EnumMember(Value = "mag_right")]
    MagRight,

    /// <summary>
    /// 🕯️
    /// </summary>
    [EnumMember(Value = "candle")]
    Candle,

    /// <summary>
    /// 💡
    /// </summary>
    [EnumMember(Value = "bulb")]
    Bulb,

    /// <summary>
    /// 🔦
    /// </summary>
    [EnumMember(Value = "flashlight")]
    Flashlight,

    /// <summary>
    /// 🏮
    /// </summary>
    [EnumMember(Value = "izakaya_lantern")]
    IzakayaLantern,

    /// <summary>
    /// 🪔
    /// </summary>
    [EnumMember(Value = "diya_lamp")]
    DiyaLamp,

    /// <summary>
    /// 📔
    /// </summary>
    [EnumMember(Value = "notebook_with_decorative_cover")]
    NotebookWithDecorativeCover,

    /// <summary>
    /// 📕
    /// </summary>
    [EnumMember(Value = "closed_book")]
    ClosedBook,

    /// <summary>
    /// 📖
    /// </summary>
    [EnumMember(Value = "book")]
    Book,

    /// <summary>
    /// 📗
    /// </summary>
    [EnumMember(Value = "green_book")]
    GreenBook,

    /// <summary>
    /// 📘
    /// </summary>
    [EnumMember(Value = "blue_book")]
    BlueBook,

    /// <summary>
    /// 📙
    /// </summary>
    [EnumMember(Value = "orange_book")]
    OrangeBook,

    /// <summary>
    /// 📚
    /// </summary>
    [EnumMember(Value = "books")]
    Books,

    /// <summary>
    /// 📓
    /// </summary>
    [EnumMember(Value = "notebook")]
    Notebook,

    /// <summary>
    /// 📒
    /// </summary>
    [EnumMember(Value = "ledger")]
    Ledger,

    /// <summary>
    /// 📃
    /// </summary>
    [EnumMember(Value = "page_with_curl")]
    PageWithCurl,

    /// <summary>
    /// 📜
    /// </summary>
    [EnumMember(Value = "scroll")]
    Scroll,

    /// <summary>
    /// 📄
    /// </summary>
    [EnumMember(Value = "page_facing_up")]
    PageFacingUp,

    /// <summary>
    /// 📰
    /// </summary>
    [EnumMember(Value = "newspaper")]
    Newspaper,

    /// <summary>
    /// 🗞️
    /// </summary>
    [EnumMember(Value = "newspaper_roll")]
    NewspaperRoll,

    /// <summary>
    /// 📑
    /// </summary>
    [EnumMember(Value = "bookmark_tabs")]
    BookmarkTabs,

    /// <summary>
    /// 🔖
    /// </summary>
    [EnumMember(Value = "bookmark")]
    Bookmark,

    /// <summary>
    /// 🏷️
    /// </summary>
    [EnumMember(Value = "label")]
    Label,

    /// <summary>
    /// 💰
    /// </summary>
    [EnumMember(Value = "moneybag")]
    Moneybag,

    /// <summary>
    /// 🪙
    /// </summary>
    [EnumMember(Value = "coin")]
    Coin,

    /// <summary>
    /// 💴
    /// </summary>
    [EnumMember(Value = "yen")]
    Yen,

    /// <summary>
    /// 💵
    /// </summary>
    [EnumMember(Value = "dollar")]
    Dollar,

    /// <summary>
    /// 💶
    /// </summary>
    [EnumMember(Value = "euro")]
    Euro,

    /// <summary>
    /// 💷
    /// </summary>
    [EnumMember(Value = "pound")]
    Pound,

    /// <summary>
    /// 💸
    /// </summary>
    [EnumMember(Value = "money_with_wings")]
    MoneyWithWings,

    /// <summary>
    /// 💳
    /// </summary>
    [EnumMember(Value = "credit_card")]
    CreditCard,

    /// <summary>
    /// 🧾
    /// </summary>
    [EnumMember(Value = "receipt")]
    Receipt,

    /// <summary>
    /// 💹
    /// </summary>
    [EnumMember(Value = "chart")]
    Chart,

    /// <summary>
    /// ✉️
    /// </summary>
    [EnumMember(Value = "envelope")]
    Envelope,

    /// <summary>
    /// 📧
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// 📨
    /// </summary>
    [EnumMember(Value = "incoming_envelope")]
    IncomingEnvelope,

    /// <summary>
    /// 📩
    /// </summary>
    [EnumMember(Value = "envelope_with_arrow")]
    EnvelopeWithArrow,

    /// <summary>
    /// 📤
    /// </summary>
    [EnumMember(Value = "outbox_tray")]
    OutboxTray,

    /// <summary>
    /// 📥
    /// </summary>
    [EnumMember(Value = "inbox_tray")]
    InboxTray,

    /// <summary>
    /// 📦
    /// </summary>
    [EnumMember(Value = "package")]
    Package,

    /// <summary>
    /// 📫
    /// </summary>
    [EnumMember(Value = "mailbox")]
    Mailbox,

    /// <summary>
    /// 📪
    /// </summary>
    [EnumMember(Value = "mailbox_closed")]
    MailboxClosed,

    /// <summary>
    /// 📬
    /// </summary>
    [EnumMember(Value = "mailbox_with_mail")]
    MailboxWithMail,

    /// <summary>
    /// 📭
    /// </summary>
    [EnumMember(Value = "mailbox_with_no_mail")]
    MailboxWithNoMail,

    /// <summary>
    /// 📮
    /// </summary>
    [EnumMember(Value = "postbox")]
    Postbox,

    /// <summary>
    /// 🗳️
    /// </summary>
    [EnumMember(Value = "ballot_box")]
    BallotBox,

    /// <summary>
    /// ✏️
    /// </summary>
    [EnumMember(Value = "pencil2")]
    Pencil2,

    /// <summary>
    /// ✒️
    /// </summary>
    [EnumMember(Value = "black_nib")]
    BlackNib,

    /// <summary>
    /// 🖋️
    /// </summary>
    [EnumMember(Value = "fountain_pen")]
    FountainPen,

    /// <summary>
    /// 🖊️
    /// </summary>
    [EnumMember(Value = "pen")]
    Pen,

    /// <summary>
    /// 🖌️
    /// </summary>
    [EnumMember(Value = "paintbrush")]
    Paintbrush,

    /// <summary>
    /// 🖍️
    /// </summary>
    [EnumMember(Value = "crayon")]
    Crayon,

    /// <summary>
    /// 📝
    /// </summary>
    [EnumMember(Value = "memo")]
    Memo,

    /// <summary>
    /// 💼
    /// </summary>
    [EnumMember(Value = "briefcase")]
    Briefcase,

    /// <summary>
    /// 📁
    /// </summary>
    [EnumMember(Value = "file_folder")]
    FileFolder,

    /// <summary>
    /// 📂
    /// </summary>
    [EnumMember(Value = "open_file_folder")]
    OpenFileFolder,

    /// <summary>
    /// 🗂️
    /// </summary>
    [EnumMember(Value = "card_index_dividers")]
    CardIndexDividers,

    /// <summary>
    /// 📅
    /// </summary>
    [EnumMember(Value = "date")]
    Date,

    /// <summary>
    /// 📆
    /// </summary>
    [EnumMember(Value = "calendar")]
    Calendar,

    /// <summary>
    /// 🗒️
    /// </summary>
    [EnumMember(Value = "spiral_notepad")]
    SpiralNotepad,

    /// <summary>
    /// 🗓️
    /// </summary>
    [EnumMember(Value = "spiral_calendar")]
    SpiralCalendar,

    /// <summary>
    /// 📇
    /// </summary>
    [EnumMember(Value = "card_index")]
    CardIndex,

    /// <summary>
    /// 📈
    /// </summary>
    [EnumMember(Value = "chart_with_upwards_trend")]
    ChartWithUpwardsTrend,

    /// <summary>
    /// 📉
    /// </summary>
    [EnumMember(Value = "chart_with_downwards_trend")]
    ChartWithDownwardsTrend,

    /// <summary>
    /// 📊
    /// </summary>
    [EnumMember(Value = "bar_chart")]
    BarChart,

    /// <summary>
    /// 📋
    /// </summary>
    [EnumMember(Value = "clipboard")]
    Clipboard,

    /// <summary>
    /// 📌
    /// </summary>
    [EnumMember(Value = "pushpin")]
    Pushpin,

    /// <summary>
    /// 📍
    /// </summary>
    [EnumMember(Value = "round_pushpin")]
    RoundPushpin,

    /// <summary>
    /// 📎
    /// </summary>
    [EnumMember(Value = "paperclip")]
    Paperclip,

    /// <summary>
    /// 🖇️
    /// </summary>
    [EnumMember(Value = "paperclips")]
    Paperclips,

    /// <summary>
    /// 📏
    /// </summary>
    [EnumMember(Value = "straight_ruler")]
    StraightRuler,

    /// <summary>
    /// 📐
    /// </summary>
    [EnumMember(Value = "triangular_ruler")]
    TriangularRuler,

    /// <summary>
    /// ✂️
    /// </summary>
    [EnumMember(Value = "scissors")]
    Scissors,

    /// <summary>
    /// 🗃️
    /// </summary>
    [EnumMember(Value = "card_file_box")]
    CardFileBox,

    /// <summary>
    /// 🗄️
    /// </summary>
    [EnumMember(Value = "file_cabinet")]
    FileCabinet,

    /// <summary>
    /// 🗑️
    /// </summary>
    [EnumMember(Value = "wastebasket")]
    Wastebasket,

    /// <summary>
    /// 🔒
    /// </summary>
    [EnumMember(Value = "lock")]
    Lock,

    /// <summary>
    /// 🔓
    /// </summary>
    [EnumMember(Value = "unlock")]
    Unlock,

    /// <summary>
    /// 🔏
    /// </summary>
    [EnumMember(Value = "lock_with_ink_pen")]
    LockWithInkPen,

    /// <summary>
    /// 🔐
    /// </summary>
    [EnumMember(Value = "closed_lock_with_key")]
    ClosedLockWithKey,

    /// <summary>
    /// 🔑
    /// </summary>
    [EnumMember(Value = "key")]
    Key,

    /// <summary>
    /// 🗝️
    /// </summary>
    [EnumMember(Value = "old_key")]
    OldKey,

    /// <summary>
    /// 🔨
    /// </summary>
    [EnumMember(Value = "hammer")]
    Hammer,

    /// <summary>
    /// 🪓
    /// </summary>
    [EnumMember(Value = "axe")]
    Axe,

    /// <summary>
    /// ⛏️
    /// </summary>
    [EnumMember(Value = "pick")]
    Pick,

    /// <summary>
    /// ⚒️
    /// </summary>
    [EnumMember(Value = "hammer_and_pick")]
    HammerAndPick,

    /// <summary>
    /// 🛠️
    /// </summary>
    [EnumMember(Value = "hammer_and_wrench")]
    HammerAndWrench,

    /// <summary>
    /// 🗡️
    /// </summary>
    [EnumMember(Value = "dagger")]
    Dagger,

    /// <summary>
    /// ⚔️
    /// </summary>
    [EnumMember(Value = "crossed_swords")]
    CrossedSwords,

    /// <summary>
    /// 🔫
    /// </summary>
    [EnumMember(Value = "gun")]
    Gun,

    /// <summary>
    /// 🪃
    /// </summary>
    [EnumMember(Value = "boomerang")]
    Boomerang,

    /// <summary>
    /// 🏹
    /// </summary>
    [EnumMember(Value = "bow_and_arrow")]
    BowAndArrow,

    /// <summary>
    /// 🛡️
    /// </summary>
    [EnumMember(Value = "shield")]
    Shield,

    /// <summary>
    /// 🪚
    /// </summary>
    [EnumMember(Value = "carpentry_saw")]
    CarpentrySaw,

    /// <summary>
    /// 🔧
    /// </summary>
    [EnumMember(Value = "wrench")]
    Wrench,

    /// <summary>
    /// 🪛
    /// </summary>
    [EnumMember(Value = "screwdriver")]
    Screwdriver,

    /// <summary>
    /// 🔩
    /// </summary>
    [EnumMember(Value = "nut_and_bolt")]
    NutAndBolt,

    /// <summary>
    /// ⚙️
    /// </summary>
    [EnumMember(Value = "gear")]
    Gear,

    /// <summary>
    /// 🗜️
    /// </summary>
    [EnumMember(Value = "clamp")]
    Clamp,

    /// <summary>
    /// ⚖️
    /// </summary>
    [EnumMember(Value = "balance_scale")]
    BalanceScale,

    /// <summary>
    /// 🦯
    /// </summary>
    [EnumMember(Value = "probing_cane")]
    ProbingCane,

    /// <summary>
    /// 🔗
    /// </summary>
    [EnumMember(Value = "link")]
    Link,

    /// <summary>
    /// ⛓️
    /// </summary>
    [EnumMember(Value = "chains")]
    Chains,

    /// <summary>
    /// 🪝
    /// </summary>
    [EnumMember(Value = "hook")]
    Hook,

    /// <summary>
    /// 🧰
    /// </summary>
    [EnumMember(Value = "toolbox")]
    Toolbox,

    /// <summary>
    /// 🧲
    /// </summary>
    [EnumMember(Value = "magnet")]
    Magnet,

    /// <summary>
    /// 🪜
    /// </summary>
    [EnumMember(Value = "ladder")]
    Ladder,

    /// <summary>
    /// ⚗️
    /// </summary>
    [EnumMember(Value = "alembic")]
    Alembic,

    /// <summary>
    /// 🧪
    /// </summary>
    [EnumMember(Value = "test_tube")]
    TestTube,

    /// <summary>
    /// 🧫
    /// </summary>
    [EnumMember(Value = "petri_dish")]
    PetriDish,

    /// <summary>
    /// 🧬
    /// </summary>
    [EnumMember(Value = "dna")]
    Dna,

    /// <summary>
    /// 🔬
    /// </summary>
    [EnumMember(Value = "microscope")]
    Microscope,

    /// <summary>
    /// 🔭
    /// </summary>
    [EnumMember(Value = "telescope")]
    Telescope,

    /// <summary>
    /// 📡
    /// </summary>
    [EnumMember(Value = "satellite")]
    Satellite,

    /// <summary>
    /// 💉
    /// </summary>
    [EnumMember(Value = "syringe")]
    Syringe,

    /// <summary>
    /// 🩸
    /// </summary>
    [EnumMember(Value = "drop_of_blood")]
    DropOfBlood,

    /// <summary>
    /// 💊
    /// </summary>
    [EnumMember(Value = "pill")]
    Pill,

    /// <summary>
    /// 🩹
    /// </summary>
    [EnumMember(Value = "adhesive_bandage")]
    AdhesiveBandage,

    /// <summary>
    /// 🩺
    /// </summary>
    [EnumMember(Value = "stethoscope")]
    Stethoscope,

    /// <summary>
    /// 🚪
    /// </summary>
    [EnumMember(Value = "door")]
    Door,

    /// <summary>
    /// 🛗
    /// </summary>
    [EnumMember(Value = "elevator")]
    Elevator,

    /// <summary>
    /// 🪞
    /// </summary>
    [EnumMember(Value = "mirror")]
    Mirror,

    /// <summary>
    /// 🪟
    /// </summary>
    [EnumMember(Value = "window")]
    Window,

    /// <summary>
    /// 🛏️
    /// </summary>
    [EnumMember(Value = "bed")]
    Bed,

    /// <summary>
    /// 🛋️
    /// </summary>
    [EnumMember(Value = "couch_and_lamp")]
    CouchAndLamp,

    /// <summary>
    /// 🪑
    /// </summary>
    [EnumMember(Value = "chair")]
    Chair,

    /// <summary>
    /// 🚽
    /// </summary>
    [EnumMember(Value = "toilet")]
    Toilet,

    /// <summary>
    /// 🪠
    /// </summary>
    [EnumMember(Value = "plunger")]
    Plunger,

    /// <summary>
    /// 🚿
    /// </summary>
    [EnumMember(Value = "shower")]
    Shower,

    /// <summary>
    /// 🛁
    /// </summary>
    [EnumMember(Value = "bathtub")]
    Bathtub,

    /// <summary>
    /// 🪤
    /// </summary>
    [EnumMember(Value = "mouse_trap")]
    MouseTrap,

    /// <summary>
    /// 🪒
    /// </summary>
    [EnumMember(Value = "razor")]
    Razor,

    /// <summary>
    /// 🧴
    /// </summary>
    [EnumMember(Value = "lotion_bottle")]
    LotionBottle,

    /// <summary>
    /// 🧷
    /// </summary>
    [EnumMember(Value = "safety_pin")]
    SafetyPin,

    /// <summary>
    /// 🧹
    /// </summary>
    [EnumMember(Value = "broom")]
    Broom,

    /// <summary>
    /// 🧺
    /// </summary>
    [EnumMember(Value = "basket")]
    Basket,

    /// <summary>
    /// 🧻
    /// </summary>
    [EnumMember(Value = "roll_of_paper")]
    RollOfPaper,

    /// <summary>
    /// 🪣
    /// </summary>
    [EnumMember(Value = "bucket")]
    Bucket,

    /// <summary>
    /// 🧼
    /// </summary>
    [EnumMember(Value = "soap")]
    Soap,

    /// <summary>
    /// 🪥
    /// </summary>
    [EnumMember(Value = "toothbrush")]
    Toothbrush,

    /// <summary>
    /// 🧽
    /// </summary>
    [EnumMember(Value = "sponge")]
    Sponge,

    /// <summary>
    /// 🧯
    /// </summary>
    [EnumMember(Value = "fire_extinguisher")]
    FireExtinguisher,

    /// <summary>
    /// 🛒
    /// </summary>
    [EnumMember(Value = "shopping_cart")]
    ShoppingCart,

    /// <summary>
    /// 🚬
    /// </summary>
    [EnumMember(Value = "smoking")]
    Smoking,

    /// <summary>
    /// ⚰️
    /// </summary>
    [EnumMember(Value = "coffin")]
    Coffin,

    /// <summary>
    /// 🪦
    /// </summary>
    [EnumMember(Value = "headstone")]
    Headstone,

    /// <summary>
    /// ⚱️
    /// </summary>
    [EnumMember(Value = "funeral_urn")]
    FuneralUrn,

    /// <summary>
    /// 🗿
    /// </summary>
    [EnumMember(Value = "moyai")]
    Moyai,

    /// <summary>
    /// 🪧
    /// </summary>
    [EnumMember(Value = "placard")]
    Placard,

    /// <summary>
    /// 🏧
    /// </summary>
    [EnumMember(Value = "atm")]
    Atm,

    /// <summary>
    /// 🚮
    /// </summary>
    [EnumMember(Value = "put_litter_in_its_place")]
    PutLitterInItsPlace,

    /// <summary>
    /// 🚰
    /// </summary>
    [EnumMember(Value = "potable_water")]
    PotableWater,

    /// <summary>
    /// ♿
    /// </summary>
    [EnumMember(Value = "wheelchair")]
    Wheelchair,

    /// <summary>
    /// 🚹
    /// </summary>
    [EnumMember(Value = "mens")]
    Mens,

    /// <summary>
    /// 🚺
    /// </summary>
    [EnumMember(Value = "womens")]
    Womens,

    /// <summary>
    /// 🚻
    /// </summary>
    [EnumMember(Value = "restroom")]
    Restroom,

    /// <summary>
    /// 🚼
    /// </summary>
    [EnumMember(Value = "baby_symbol")]
    BabySymbol,

    /// <summary>
    /// 🚾
    /// </summary>
    [EnumMember(Value = "wc")]
    Wc,

    /// <summary>
    /// 🛂
    /// </summary>
    [EnumMember(Value = "passport_control")]
    PassportControl,

    /// <summary>
    /// 🛃
    /// </summary>
    [EnumMember(Value = "customs")]
    Customs,

    /// <summary>
    /// 🛄
    /// </summary>
    [EnumMember(Value = "baggage_claim")]
    BaggageClaim,

    /// <summary>
    /// 🛅
    /// </summary>
    [EnumMember(Value = "left_luggage")]
    LeftLuggage,

    /// <summary>
    /// ⚠️
    /// </summary>
    [EnumMember(Value = "warning")]
    Warning,

    /// <summary>
    /// 🚸
    /// </summary>
    [EnumMember(Value = "children_crossing")]
    ChildrenCrossing,

    /// <summary>
    /// ⛔
    /// </summary>
    [EnumMember(Value = "no_entry")]
    NoEntry,

    /// <summary>
    /// 🚫
    /// </summary>
    [EnumMember(Value = "no_entry_sign")]
    NoEntrySign,

    /// <summary>
    /// 🚳
    /// </summary>
    [EnumMember(Value = "no_bicycles")]
    NoBicycles,

    /// <summary>
    /// 🚭
    /// </summary>
    [EnumMember(Value = "no_smoking")]
    NoSmoking,

    /// <summary>
    /// 🚯
    /// </summary>
    [EnumMember(Value = "do_not_litter")]
    DoNotLitter,

    /// <summary>
    /// 🚱
    /// </summary>
    [EnumMember(Value = "non-potable_water")]
    NonPotableWater,

    /// <summary>
    /// 🚷
    /// </summary>
    [EnumMember(Value = "no_pedestrians")]
    NoPedestrians,

    /// <summary>
    /// 📵
    /// </summary>
    [EnumMember(Value = "no_mobile_phones")]
    NoMobilePhones,

    /// <summary>
    /// 🔞
    /// </summary>
    [EnumMember(Value = "underage")]
    Underage,

    /// <summary>
    /// ☢️
    /// </summary>
    [EnumMember(Value = "radioactive")]
    Radioactive,

    /// <summary>
    /// ☣️
    /// </summary>
    [EnumMember(Value = "biohazard")]
    Biohazard,

    /// <summary>
    /// ⬆️
    /// </summary>
    [EnumMember(Value = "arrow_up")]
    ArrowUp,

    /// <summary>
    /// ↗️
    /// </summary>
    [EnumMember(Value = "arrow_upper_right")]
    ArrowUpperRight,

    /// <summary>
    /// ➡️
    /// </summary>
    [EnumMember(Value = "arrow_right")]
    ArrowRight,

    /// <summary>
    /// ↘️
    /// </summary>
    [EnumMember(Value = "arrow_lower_right")]
    ArrowLowerRight,

    /// <summary>
    /// ⬇️
    /// </summary>
    [EnumMember(Value = "arrow_down")]
    ArrowDown,

    /// <summary>
    /// ↙️
    /// </summary>
    [EnumMember(Value = "arrow_lower_left")]
    ArrowLowerLeft,

    /// <summary>
    /// ⬅️
    /// </summary>
    [EnumMember(Value = "arrow_left")]
    ArrowLeft,

    /// <summary>
    /// ↖️
    /// </summary>
    [EnumMember(Value = "arrow_upper_left")]
    ArrowUpperLeft,

    /// <summary>
    /// ↕️
    /// </summary>
    [EnumMember(Value = "arrow_up_down")]
    ArrowUpDown,

    /// <summary>
    /// ↔️
    /// </summary>
    [EnumMember(Value = "left_right_arrow")]
    LeftRightArrow,

    /// <summary>
    /// ↩️
    /// </summary>
    [EnumMember(Value = "leftwards_arrow_with_hook")]
    LeftwardsArrowWithHook,

    /// <summary>
    /// ↪️
    /// </summary>
    [EnumMember(Value = "arrow_right_hook")]
    ArrowRightHook,

    /// <summary>
    /// ⤴️
    /// </summary>
    [EnumMember(Value = "arrow_heading_up")]
    ArrowHeadingUp,

    /// <summary>
    /// ⤵️
    /// </summary>
    [EnumMember(Value = "arrow_heading_down")]
    ArrowHeadingDown,

    /// <summary>
    /// 🔃
    /// </summary>
    [EnumMember(Value = "arrows_clockwise")]
    ArrowsClockwise,

    /// <summary>
    /// 🔄
    /// </summary>
    [EnumMember(Value = "arrows_counterclockwise")]
    ArrowsCounterclockwise,

    /// <summary>
    /// 🔙
    /// </summary>
    [EnumMember(Value = "back")]
    Back,

    /// <summary>
    /// 🔚
    /// </summary>
    [EnumMember(Value = "end")]
    End,

    /// <summary>
    /// 🔛
    /// </summary>
    [EnumMember(Value = "on")]
    On,

    /// <summary>
    /// 🔜
    /// </summary>
    [EnumMember(Value = "soon")]
    Soon,

    /// <summary>
    /// 🔝
    /// </summary>
    [EnumMember(Value = "top")]
    Top,

    /// <summary>
    /// 🛐
    /// </summary>
    [EnumMember(Value = "place_of_worship")]
    PlaceOfWorship,

    /// <summary>
    /// ⚛️
    /// </summary>
    [EnumMember(Value = "atom_symbol")]
    AtomSymbol,

    /// <summary>
    /// 🕉️
    /// </summary>
    [EnumMember(Value = "om")]
    Om,

    /// <summary>
    /// ✡️
    /// </summary>
    [EnumMember(Value = "star_of_david")]
    StarOfDavid,

    /// <summary>
    /// ☸️
    /// </summary>
    [EnumMember(Value = "wheel_of_dharma")]
    WheelOfDharma,

    /// <summary>
    /// ☯️
    /// </summary>
    [EnumMember(Value = "yin_yang")]
    YinYang,

    /// <summary>
    /// ✝️
    /// </summary>
    [EnumMember(Value = "latin_cross")]
    LatinCross,

    /// <summary>
    /// ☦️
    /// </summary>
    [EnumMember(Value = "orthodox_cross")]
    OrthodoxCross,

    /// <summary>
    /// ☪️
    /// </summary>
    [EnumMember(Value = "star_and_crescent")]
    StarAndCrescent,

    /// <summary>
    /// ☮️
    /// </summary>
    [EnumMember(Value = "peace_symbol")]
    PeaceSymbol,

    /// <summary>
    /// 🕎
    /// </summary>
    [EnumMember(Value = "menorah")]
    Menorah,

    /// <summary>
    /// 🔯
    /// </summary>
    [EnumMember(Value = "six_pointed_star")]
    SixPointedStar,

    /// <summary>
    /// ♈
    /// </summary>
    [EnumMember(Value = "aries")]
    Aries,

    /// <summary>
    /// ♉
    /// </summary>
    [EnumMember(Value = "taurus")]
    Taurus,

    /// <summary>
    /// ♊
    /// </summary>
    [EnumMember(Value = "gemini")]
    Gemini,

    /// <summary>
    /// ♋
    /// </summary>
    [EnumMember(Value = "cancer")]
    Cancer,

    /// <summary>
    /// ♌
    /// </summary>
    [EnumMember(Value = "leo")]
    Leo,

    /// <summary>
    /// ♍
    /// </summary>
    [EnumMember(Value = "virgo")]
    Virgo,

    /// <summary>
    /// ♎
    /// </summary>
    [EnumMember(Value = "libra")]
    Libra,

    /// <summary>
    /// ♏
    /// </summary>
    [EnumMember(Value = "scorpius")]
    Scorpius,

    /// <summary>
    /// ♐
    /// </summary>
    [EnumMember(Value = "sagittarius")]
    Sagittarius,

    /// <summary>
    /// ♑
    /// </summary>
    [EnumMember(Value = "capricorn")]
    Capricorn,

    /// <summary>
    /// ♒
    /// </summary>
    [EnumMember(Value = "aquarius")]
    Aquarius,

    /// <summary>
    /// ♓
    /// </summary>
    [EnumMember(Value = "pisces")]
    Pisces,

    /// <summary>
    /// ⛎
    /// </summary>
    [EnumMember(Value = "ophiuchus")]
    Ophiuchus,

    /// <summary>
    /// 🔀
    /// </summary>
    [EnumMember(Value = "twisted_rightwards_arrows")]
    TwistedRightwardsArrows,

    /// <summary>
    /// 🔁
    /// </summary>
    [EnumMember(Value = "repeat")]
    Repeat,

    /// <summary>
    /// 🔂
    /// </summary>
    [EnumMember(Value = "repeat_one")]
    RepeatOne,

    /// <summary>
    /// ▶️
    /// </summary>
    [EnumMember(Value = "arrow_forward")]
    ArrowForward,

    /// <summary>
    /// ⏩
    /// </summary>
    [EnumMember(Value = "fast_forward")]
    FastForward,

    /// <summary>
    /// ⏭️
    /// </summary>
    [EnumMember(Value = "next_track_button")]
    NextTrackButton,

    /// <summary>
    /// ⏯️
    /// </summary>
    [EnumMember(Value = "play_or_pause_button")]
    PlayOrPauseButton,

    /// <summary>
    /// ◀️
    /// </summary>
    [EnumMember(Value = "arrow_backward")]
    ArrowBackward,

    /// <summary>
    /// ⏪
    /// </summary>
    [EnumMember(Value = "rewind")]
    Rewind,

    /// <summary>
    /// ⏮️
    /// </summary>
    [EnumMember(Value = "previous_track_button")]
    PreviousTrackButton,

    /// <summary>
    /// 🔼
    /// </summary>
    [EnumMember(Value = "arrow_up_small")]
    ArrowUpSmall,

    /// <summary>
    /// ⏫
    /// </summary>
    [EnumMember(Value = "arrow_double_up")]
    ArrowDoubleUp,

    /// <summary>
    /// 🔽
    /// </summary>
    [EnumMember(Value = "arrow_down_small")]
    ArrowDownSmall,

    /// <summary>
    /// ⏬
    /// </summary>
    [EnumMember(Value = "arrow_double_down")]
    ArrowDoubleDown,

    /// <summary>
    /// ⏸️
    /// </summary>
    [EnumMember(Value = "pause_button")]
    PauseButton,

    /// <summary>
    /// ⏹️
    /// </summary>
    [EnumMember(Value = "stop_button")]
    StopButton,

    /// <summary>
    /// ⏺️
    /// </summary>
    [EnumMember(Value = "record_button")]
    RecordButton,

    /// <summary>
    /// ⏏️
    /// </summary>
    [EnumMember(Value = "eject_button")]
    EjectButton,

    /// <summary>
    /// 🎦
    /// </summary>
    [EnumMember(Value = "cinema")]
    Cinema,

    /// <summary>
    /// 🔅
    /// </summary>
    [EnumMember(Value = "low_brightness")]
    LowBrightness,

    /// <summary>
    /// 🔆
    /// </summary>
    [EnumMember(Value = "high_brightness")]
    HighBrightness,

    /// <summary>
    /// 📶
    /// </summary>
    [EnumMember(Value = "signal_strength")]
    SignalStrength,

    /// <summary>
    /// 📳
    /// </summary>
    [EnumMember(Value = "vibration_mode")]
    VibrationMode,

    /// <summary>
    /// 📴
    /// </summary>
    [EnumMember(Value = "mobile_phone_off")]
    MobilePhoneOff,

    /// <summary>
    /// ♀️
    /// </summary>
    [EnumMember(Value = "female_sign")]
    FemaleSign,

    /// <summary>
    /// ♂️
    /// </summary>
    [EnumMember(Value = "male_sign")]
    MaleSign,

    /// <summary>
    /// ⚧️
    /// </summary>
    [EnumMember(Value = "transgender_symbol")]
    TransgenderSymbol,

    /// <summary>
    /// ✖️
    /// </summary>
    [EnumMember(Value = "heavy_multiplication_x")]
    HeavyMultiplicationX,

    /// <summary>
    /// ➕
    /// </summary>
    [EnumMember(Value = "heavy_plus_sign")]
    HeavyPlusSign,

    /// <summary>
    /// ➖
    /// </summary>
    [EnumMember(Value = "heavy_minus_sign")]
    HeavyMinusSign,

    /// <summary>
    /// ➗
    /// </summary>
    [EnumMember(Value = "heavy_division_sign")]
    HeavyDivisionSign,

    /// <summary>
    /// ♾️
    /// </summary>
    [EnumMember(Value = "infinity")]
    Infinity,

    /// <summary>
    /// ‼️
    /// </summary>
    [EnumMember(Value = "bangbang")]
    Bangbang,

    /// <summary>
    /// ⁉️
    /// </summary>
    [EnumMember(Value = "interrobang")]
    Interrobang,

    /// <summary>
    /// ❓
    /// </summary>
    [EnumMember(Value = "question")]
    Question,

    /// <summary>
    /// ❔
    /// </summary>
    [EnumMember(Value = "grey_question")]
    GreyQuestion,

    /// <summary>
    /// ❕
    /// </summary>
    [EnumMember(Value = "grey_exclamation")]
    GreyExclamation,

    /// <summary>
    /// ❗
    /// </summary>
    [EnumMember(Value = "exclamation")]
    Exclamation,

    /// <summary>
    /// 〰️
    /// </summary>
    [EnumMember(Value = "wavy_dash")]
    WavyDash,

    /// <summary>
    /// 💱
    /// </summary>
    [EnumMember(Value = "currency_exchange")]
    CurrencyExchange,

    /// <summary>
    /// 💲
    /// </summary>
    [EnumMember(Value = "heavy_dollar_sign")]
    HeavyDollarSign,

    /// <summary>
    /// ⚕️
    /// </summary>
    [EnumMember(Value = "medical_symbol")]
    MedicalSymbol,

    /// <summary>
    /// ♻️
    /// </summary>
    [EnumMember(Value = "recycle")]
    Recycle,

    /// <summary>
    /// ⚜️
    /// </summary>
    [EnumMember(Value = "fleur_de_lis")]
    FleurDeLis,

    /// <summary>
    /// 🔱
    /// </summary>
    [EnumMember(Value = "trident")]
    Trident,

    /// <summary>
    /// 📛
    /// </summary>
    [EnumMember(Value = "name_badge")]
    NameBadge,

    /// <summary>
    /// 🔰
    /// </summary>
    [EnumMember(Value = "beginner")]
    Beginner,

    /// <summary>
    /// ⭕
    /// </summary>
    [EnumMember(Value = "o")]
    O,

    /// <summary>
    /// ✅
    /// </summary>
    [EnumMember(Value = "white_check_mark")]
    WhiteCheckMark,

    /// <summary>
    /// ☑️
    /// </summary>
    [EnumMember(Value = "ballot_box_with_check")]
    BallotBoxWithCheck,

    /// <summary>
    /// ✔️
    /// </summary>
    [EnumMember(Value = "heavy_check_mark")]
    HeavyCheckMark,

    /// <summary>
    /// ❌
    /// </summary>
    [EnumMember(Value = "x")]
    X,

    /// <summary>
    /// ❎
    /// </summary>
    [EnumMember(Value = "negative_squared_cross_mark")]
    NegativeSquaredCrossMark,

    /// <summary>
    /// ➰
    /// </summary>
    [EnumMember(Value = "curly_loop")]
    CurlyLoop,

    /// <summary>
    /// ➿
    /// </summary>
    [EnumMember(Value = "loop")]
    Loop,

    /// <summary>
    /// 〽️
    /// </summary>
    [EnumMember(Value = "part_alternation_mark")]
    PartAlternationMark,

    /// <summary>
    /// ✳️
    /// </summary>
    [EnumMember(Value = "eight_spoked_asterisk")]
    EightSpokedAsterisk,

    /// <summary>
    /// ✴️
    /// </summary>
    [EnumMember(Value = "eight_pointed_black_star")]
    EightPointedBlackStar,

    /// <summary>
    /// ❇️
    /// </summary>
    [EnumMember(Value = "sparkle")]
    Sparkle,

    /// <summary>
    /// ©️
    /// </summary>
    [EnumMember(Value = "copyright")]
    Copyright,

    /// <summary>
    /// ®️
    /// </summary>
    [EnumMember(Value = "registered")]
    Registered,

    /// <summary>
    /// ™️
    /// </summary>
    [EnumMember(Value = "tm")]
    Tm,

    /// <summary>
    /// #️⃣
    /// </summary>
    [EnumMember(Value = "hash")]
    Hash,

    /// <summary>
    /// *️⃣
    /// </summary>
    [EnumMember(Value = "asterisk")]
    Asterisk,

    /// <summary>
    /// 0️⃣
    /// </summary>
    [EnumMember(Value = "zero")]
    Zero,

    /// <summary>
    /// 1️⃣
    /// </summary>
    [EnumMember(Value = "one")]
    One,

    /// <summary>
    /// 2️⃣
    /// </summary>
    [EnumMember(Value = "two")]
    Two,

    /// <summary>
    /// 3️⃣
    /// </summary>
    [EnumMember(Value = "three")]
    Three,

    /// <summary>
    /// 4️⃣
    /// </summary>
    [EnumMember(Value = "four")]
    Four,

    /// <summary>
    /// 5️⃣
    /// </summary>
    [EnumMember(Value = "five")]
    Five,

    /// <summary>
    /// 6️⃣
    /// </summary>
    [EnumMember(Value = "six")]
    Six,

    /// <summary>
    /// 7️⃣
    /// </summary>
    [EnumMember(Value = "seven")]
    Seven,

    /// <summary>
    /// 8️⃣
    /// </summary>
    [EnumMember(Value = "eight")]
    Eight,

    /// <summary>
    /// 9️⃣
    /// </summary>
    [EnumMember(Value = "nine")]
    Nine,

    /// <summary>
    /// 🔟
    /// </summary>
    [EnumMember(Value = "keycap_ten")]
    KeycapTen,

    /// <summary>
    /// 🔠
    /// </summary>
    [EnumMember(Value = "capital_abcd")]
    CapitalAbcd,

    /// <summary>
    /// 🔡
    /// </summary>
    [EnumMember(Value = "abcd")]
    Abcd,

    /// <summary>
    /// 🔢
    /// </summary>
    [EnumMember(Value = "1234")]
    OneTwoThreeFour,

    /// <summary>
    /// 🔣
    /// </summary>
    [EnumMember(Value = "symbols")]
    Symbols,

    /// <summary>
    /// 🔤
    /// </summary>
    [EnumMember(Value = "abc")]
    Abc,

    /// <summary>
    /// 🅰️
    /// </summary>
    [EnumMember(Value = "a")]
    A,

    /// <summary>
    /// 🆎
    /// </summary>
    [EnumMember(Value = "ab")]
    Ab,

    /// <summary>
    /// 🅱️
    /// </summary>
    [EnumMember(Value = "b")]
    B,

    /// <summary>
    /// 🆑
    /// </summary>
    [EnumMember(Value = "cl")]
    Cl,

    /// <summary>
    /// 🆒
    /// </summary>
    [EnumMember(Value = "cool")]
    Cool,

    /// <summary>
    /// 🆓
    /// </summary>
    [EnumMember(Value = "free")]
    Free,

    /// <summary>
    /// ℹ️
    /// </summary>
    [EnumMember(Value = "information_source")]
    InformationSource,

    /// <summary>
    /// 🆔
    /// </summary>
    [EnumMember(Value = "id")]
    Id,

    /// <summary>
    /// Ⓜ️
    /// </summary>
    [EnumMember(Value = "m")]
    M,

    /// <summary>
    /// 🆕
    /// </summary>
    [EnumMember(Value = "new")]
    New,

    /// <summary>
    /// 🆖
    /// </summary>
    [EnumMember(Value = "ng")]
    Ng,

    /// <summary>
    /// 🅾️
    /// </summary>
    [EnumMember(Value = "o2")]
    O2,

    /// <summary>
    /// 🆗
    /// </summary>
    [EnumMember(Value = "ok")]
    Ok,

    /// <summary>
    /// 🅿️
    /// </summary>
    [EnumMember(Value = "parking")]
    Parking,

    /// <summary>
    /// 🆘
    /// </summary>
    [EnumMember(Value = "sos")]
    Sos,

    /// <summary>
    /// 🆙
    /// </summary>
    [EnumMember(Value = "up")]
    Up,

    /// <summary>
    /// 🆚
    /// </summary>
    [EnumMember(Value = "vs")]
    Vs,

    /// <summary>
    /// 🈁
    /// </summary>
    [EnumMember(Value = "koko")]
    Koko,

    /// <summary>
    /// 🈂️
    /// </summary>
    [EnumMember(Value = "sa")]
    Sa,

    /// <summary>
    /// 🈷️
    /// </summary>
    [EnumMember(Value = "u6708")]
    U6708,

    /// <summary>
    /// 🈶
    /// </summary>
    [EnumMember(Value = "u6709")]
    U6709,

    /// <summary>
    /// 🈯
    /// </summary>
    [EnumMember(Value = "u6307")]
    U6307,

    /// <summary>
    /// 🉐
    /// </summary>
    [EnumMember(Value = "ideograph_advantage")]
    IdeographAdvantage,

    /// <summary>
    /// 🈹
    /// </summary>
    [EnumMember(Value = "u5272")]
    U5272,

    /// <summary>
    /// 🈚
    /// </summary>
    [EnumMember(Value = "u7121")]
    U7121,

    /// <summary>
    /// 🈲
    /// </summary>
    [EnumMember(Value = "u7981")]
    U7981,

    /// <summary>
    /// 🉑
    /// </summary>
    [EnumMember(Value = "accept")]
    Accept,

    /// <summary>
    /// 🈸
    /// </summary>
    [EnumMember(Value = "u7533")]
    U7533,

    /// <summary>
    /// 🈴
    /// </summary>
    [EnumMember(Value = "u5408")]
    U5408,

    /// <summary>
    /// 🈳
    /// </summary>
    [EnumMember(Value = "u7a7a")]
    U7a7a,

    /// <summary>
    /// ㊗️
    /// </summary>
    [EnumMember(Value = "congratulations")]
    Congratulations,

    /// <summary>
    /// ㊙️
    /// </summary>
    [EnumMember(Value = "secret")]
    Secret,

    /// <summary>
    /// 🈺
    /// </summary>
    [EnumMember(Value = "u55b6")]
    U55b6,

    /// <summary>
    /// 🈵
    /// </summary>
    [EnumMember(Value = "u6e80")]
    U6e80,

    /// <summary>
    /// 🔴
    /// </summary>
    [EnumMember(Value = "red_circle")]
    RedCircle,

    /// <summary>
    /// 🟠
    /// </summary>
    [EnumMember(Value = "orange_circle")]
    OrangeCircle,

    /// <summary>
    /// 🟡
    /// </summary>
    [EnumMember(Value = "yellow_circle")]
    YellowCircle,

    /// <summary>
    /// 🟢
    /// </summary>
    [EnumMember(Value = "green_circle")]
    GreenCircle,

    /// <summary>
    /// 🔵
    /// </summary>
    [EnumMember(Value = "large_blue_circle")]
    LargeBlueCircle,

    /// <summary>
    /// 🟣
    /// </summary>
    [EnumMember(Value = "purple_circle")]
    PurpleCircle,

    /// <summary>
    /// 🟤
    /// </summary>
    [EnumMember(Value = "brown_circle")]
    BrownCircle,

    /// <summary>
    /// ⚫
    /// </summary>
    [EnumMember(Value = "black_circle")]
    BlackCircle,

    /// <summary>
    /// ⚪
    /// </summary>
    [EnumMember(Value = "white_circle")]
    WhiteCircle,

    /// <summary>
    /// 🟥
    /// </summary>
    [EnumMember(Value = "red_square")]
    RedSquare,

    /// <summary>
    /// 🟧
    /// </summary>
    [EnumMember(Value = "orange_square")]
    OrangeSquare,

    /// <summary>
    /// 🟨
    /// </summary>
    [EnumMember(Value = "yellow_square")]
    YellowSquare,

    /// <summary>
    /// 🟩
    /// </summary>
    [EnumMember(Value = "green_square")]
    GreenSquare,

    /// <summary>
    /// 🟦
    /// </summary>
    [EnumMember(Value = "blue_square")]
    BlueSquare,

    /// <summary>
    /// 🟪
    /// </summary>
    [EnumMember(Value = "purple_square")]
    PurpleSquare,

    /// <summary>
    /// 🟫
    /// </summary>
    [EnumMember(Value = "brown_square")]
    BrownSquare,

    /// <summary>
    /// ⬛
    /// </summary>
    [EnumMember(Value = "black_large_square")]
    BlackLargeSquare,

    /// <summary>
    /// ⬜
    /// </summary>
    [EnumMember(Value = "white_large_square")]
    WhiteLargeSquare,

    /// <summary>
    /// ◼️
    /// </summary>
    [EnumMember(Value = "black_medium_square")]
    BlackMediumSquare,

    /// <summary>
    /// ◻️
    /// </summary>
    [EnumMember(Value = "white_medium_square")]
    WhiteMediumSquare,

    /// <summary>
    /// ◾
    /// </summary>
    [EnumMember(Value = "black_medium_small_square")]
    BlackMediumSmallSquare,

    /// <summary>
    /// ◽
    /// </summary>
    [EnumMember(Value = "white_medium_small_square")]
    WhiteMediumSmallSquare,

    /// <summary>
    /// ▪️
    /// </summary>
    [EnumMember(Value = "black_small_square")]
    BlackSmallSquare,

    /// <summary>
    /// ▫️
    /// </summary>
    [EnumMember(Value = "white_small_square")]
    WhiteSmallSquare,

    /// <summary>
    /// 🔶
    /// </summary>
    [EnumMember(Value = "large_orange_diamond")]
    LargeOrangeDiamond,

    /// <summary>
    /// 🔷
    /// </summary>
    [EnumMember(Value = "large_blue_diamond")]
    LargeBlueDiamond,

    /// <summary>
    /// 🔸
    /// </summary>
    [EnumMember(Value = "small_orange_diamond")]
    SmallOrangeDiamond,

    /// <summary>
    /// 🔹
    /// </summary>
    [EnumMember(Value = "small_blue_diamond")]
    SmallBlueDiamond,

    /// <summary>
    /// 🔺
    /// </summary>
    [EnumMember(Value = "small_red_triangle")]
    SmallRedTriangle,

    /// <summary>
    /// 🔻
    /// </summary>
    [EnumMember(Value = "small_red_triangle_down")]
    SmallRedTriangleDown,

    /// <summary>
    /// 💠
    /// </summary>
    [EnumMember(Value = "diamond_shape_with_a_dot_inside")]
    DiamondShapeWithADotInside,

    /// <summary>
    /// 🔘
    /// </summary>
    [EnumMember(Value = "radio_button")]
    RadioButton,

    /// <summary>
    /// 🔳
    /// </summary>
    [EnumMember(Value = "white_square_button")]
    WhiteSquareButton,

    /// <summary>
    /// 🔲
    /// </summary>
    [EnumMember(Value = "black_square_button")]
    BlackSquareButton,

    /// <summary>
    /// 🏁
    /// </summary>
    [EnumMember(Value = "checkered_flag")]
    CheckeredFlag,

    /// <summary>
    /// 🚩
    /// </summary>
    [EnumMember(Value = "triangular_flag_on_post")]
    TriangularFlagOnPost,

    /// <summary>
    /// 🎌
    /// </summary>
    [EnumMember(Value = "crossed_flags")]
    CrossedFlags,

    /// <summary>
    /// 🏴
    /// </summary>
    [EnumMember(Value = "black_flag")]
    BlackFlag,

    /// <summary>
    /// 🏳️
    /// </summary>
    [EnumMember(Value = "white_flag")]
    WhiteFlag,

    /// <summary>
    /// 🏳️‍🌈
    /// </summary>
    [EnumMember(Value = "rainbow_flag")]
    RainbowFlag,

    /// <summary>
    /// 🏳️‍⚧️
    /// </summary>
    [EnumMember(Value = "transgender_flag")]
    TransgenderFlag,

    /// <summary>
    /// 🏴‍☠️
    /// </summary>
    [EnumMember(Value = "pirate_flag")]
    PirateFlag,

    /// <summary>
    /// 🇦🇨
    /// </summary>
    [EnumMember(Value = "ascension_island")]
    AscensionIsland,

    /// <summary>
    /// 🇦🇩
    /// </summary>
    [EnumMember(Value = "andorra")]
    Andorra,

    /// <summary>
    /// 🇦🇪
    /// </summary>
    [EnumMember(Value = "united_arab_emirates")]
    UnitedArabEmirates,

    /// <summary>
    /// 🇦🇫
    /// </summary>
    [EnumMember(Value = "afghanistan")]
    Afghanistan,

    /// <summary>
    /// 🇦🇬
    /// </summary>
    [EnumMember(Value = "antigua_barbuda")]
    AntiguaBarbuda,

    /// <summary>
    /// 🇦🇮
    /// </summary>
    [EnumMember(Value = "anguilla")]
    Anguilla,

    /// <summary>
    /// 🇦🇱
    /// </summary>
    [EnumMember(Value = "albania")]
    Albania,

    /// <summary>
    /// 🇦🇲
    /// </summary>
    [EnumMember(Value = "armenia")]
    Armenia,

    /// <summary>
    /// 🇦🇴
    /// </summary>
    [EnumMember(Value = "angola")]
    Angola,

    /// <summary>
    /// 🇦🇶
    /// </summary>
    [EnumMember(Value = "antarctica")]
    Antarctica,

    /// <summary>
    /// 🇦🇷
    /// </summary>
    [EnumMember(Value = "argentina")]
    Argentina,

    /// <summary>
    /// 🇦🇸
    /// </summary>
    [EnumMember(Value = "american_samoa")]
    AmericanSamoa,

    /// <summary>
    /// 🇦🇹
    /// </summary>
    [EnumMember(Value = "austria")]
    Austria,

    /// <summary>
    /// 🇦🇺
    /// </summary>
    [EnumMember(Value = "australia")]
    Australia,

    /// <summary>
    /// 🇦🇼
    /// </summary>
    [EnumMember(Value = "aruba")]
    Aruba,

    /// <summary>
    /// 🇦🇽
    /// </summary>
    [EnumMember(Value = "aland_islands")]
    AlandIslands,

    /// <summary>
    /// 🇦🇿
    /// </summary>
    [EnumMember(Value = "azerbaijan")]
    Azerbaijan,

    /// <summary>
    /// 🇧🇦
    /// </summary>
    [EnumMember(Value = "bosnia_herzegovina")]
    BosniaHerzegovina,

    /// <summary>
    /// 🇧🇧
    /// </summary>
    [EnumMember(Value = "barbados")]
    Barbados,

    /// <summary>
    /// 🇧🇩
    /// </summary>
    [EnumMember(Value = "bangladesh")]
    Bangladesh,

    /// <summary>
    /// 🇧🇪
    /// </summary>
    [EnumMember(Value = "belgium")]
    Belgium,

    /// <summary>
    /// 🇧🇫
    /// </summary>
    [EnumMember(Value = "burkina_faso")]
    BurkinaFaso,

    /// <summary>
    /// 🇧🇬
    /// </summary>
    [EnumMember(Value = "bulgaria")]
    Bulgaria,

    /// <summary>
    /// 🇧🇭
    /// </summary>
    [EnumMember(Value = "bahrain")]
    Bahrain,

    /// <summary>
    /// 🇧🇮
    /// </summary>
    [EnumMember(Value = "burundi")]
    Burundi,

    /// <summary>
    /// 🇧🇯
    /// </summary>
    [EnumMember(Value = "benin")]
    Benin,

    /// <summary>
    /// 🇧🇱
    /// </summary>
    [EnumMember(Value = "st_barthelemy")]
    StBarthelemy,

    /// <summary>
    /// 🇧🇲
    /// </summary>
    [EnumMember(Value = "bermuda")]
    Bermuda,

    /// <summary>
    /// 🇧🇳
    /// </summary>
    [EnumMember(Value = "brunei")]
    Brunei,

    /// <summary>
    /// 🇧🇴
    /// </summary>
    [EnumMember(Value = "bolivia")]
    Bolivia,

    /// <summary>
    /// 🇧🇶
    /// </summary>
    [EnumMember(Value = "caribbean_netherlands")]
    CaribbeanNetherlands,

    /// <summary>
    /// 🇧🇷
    /// </summary>
    [EnumMember(Value = "brazil")]
    Brazil,

    /// <summary>
    /// 🇧🇸
    /// </summary>
    [EnumMember(Value = "bahamas")]
    Bahamas,

    /// <summary>
    /// 🇧🇹
    /// </summary>
    [EnumMember(Value = "bhutan")]
    Bhutan,

    /// <summary>
    /// 🇧🇻
    /// </summary>
    [EnumMember(Value = "bouvet_island")]
    BouvetIsland,

    /// <summary>
    /// 🇧🇼
    /// </summary>
    [EnumMember(Value = "botswana")]
    Botswana,

    /// <summary>
    /// 🇧🇾
    /// </summary>
    [EnumMember(Value = "belarus")]
    Belarus,

    /// <summary>
    /// 🇧🇿
    /// </summary>
    [EnumMember(Value = "belize")]
    Belize,

    /// <summary>
    /// 🇨🇦
    /// </summary>
    [EnumMember(Value = "canada")]
    Canada,

    /// <summary>
    /// 🇨🇨
    /// </summary>
    [EnumMember(Value = "cocos_islands")]
    CocosIslands,

    /// <summary>
    /// 🇨🇩
    /// </summary>
    [EnumMember(Value = "congo_kinshasa")]
    CongoKinshasa,

    /// <summary>
    /// 🇨🇫
    /// </summary>
    [EnumMember(Value = "central_african_republic")]
    CentralAfricanRepublic,

    /// <summary>
    /// 🇨🇬
    /// </summary>
    [EnumMember(Value = "congo_brazzaville")]
    CongoBrazzaville,

    /// <summary>
    /// 🇨🇭
    /// </summary>
    [EnumMember(Value = "switzerland")]
    Switzerland,

    /// <summary>
    /// 🇨🇮
    /// </summary>
    [EnumMember(Value = "cote_divoire")]
    CoteDivoire,

    /// <summary>
    /// 🇨🇰
    /// </summary>
    [EnumMember(Value = "cook_islands")]
    CookIslands,

    /// <summary>
    /// 🇨🇱
    /// </summary>
    [EnumMember(Value = "chile")]
    Chile,

    /// <summary>
    /// 🇨🇲
    /// </summary>
    [EnumMember(Value = "cameroon")]
    Cameroon,

    /// <summary>
    /// 🇨🇳
    /// </summary>
    [EnumMember(Value = "cn")]
    Cn,

    /// <summary>
    /// 🇨🇴
    /// </summary>
    [EnumMember(Value = "colombia")]
    Colombia,

    /// <summary>
    /// 🇨🇵
    /// </summary>
    [EnumMember(Value = "clipperton_island")]
    ClippertonIsland,

    /// <summary>
    /// 🇨🇷
    /// </summary>
    [EnumMember(Value = "costa_rica")]
    CostaRica,

    /// <summary>
    /// 🇨🇺
    /// </summary>
    [EnumMember(Value = "cuba")]
    Cuba,

    /// <summary>
    /// 🇨🇻
    /// </summary>
    [EnumMember(Value = "cape_verde")]
    CapeVerde,

    /// <summary>
    /// 🇨🇼
    /// </summary>
    [EnumMember(Value = "curacao")]
    Curacao,

    /// <summary>
    /// 🇨🇽
    /// </summary>
    [EnumMember(Value = "christmas_island")]
    ChristmasIsland,

    /// <summary>
    /// 🇨🇾
    /// </summary>
    [EnumMember(Value = "cyprus")]
    Cyprus,

    /// <summary>
    /// 🇨🇿
    /// </summary>
    [EnumMember(Value = "czech_republic")]
    CzechRepublic,

    /// <summary>
    /// 🇩🇪
    /// </summary>
    [EnumMember(Value = "de")]
    De,

    /// <summary>
    /// 🇩🇬
    /// </summary>
    [EnumMember(Value = "diego_garcia")]
    DiegoGarcia,

    /// <summary>
    /// 🇩🇯
    /// </summary>
    [EnumMember(Value = "djibouti")]
    Djibouti,

    /// <summary>
    /// 🇩🇰
    /// </summary>
    [EnumMember(Value = "denmark")]
    Denmark,

    /// <summary>
    /// 🇩🇲
    /// </summary>
    [EnumMember(Value = "dominica")]
    Dominica,

    /// <summary>
    /// 🇩🇴
    /// </summary>
    [EnumMember(Value = "dominican_republic")]
    DominicanRepublic,

    /// <summary>
    /// 🇩🇿
    /// </summary>
    [EnumMember(Value = "algeria")]
    Algeria,

    /// <summary>
    /// 🇪🇦
    /// </summary>
    [EnumMember(Value = "ceuta_melilla")]
    CeutaMelilla,

    /// <summary>
    /// 🇪🇨
    /// </summary>
    [EnumMember(Value = "ecuador")]
    Ecuador,

    /// <summary>
    /// 🇪🇪
    /// </summary>
    [EnumMember(Value = "estonia")]
    Estonia,

    /// <summary>
    /// 🇪🇬
    /// </summary>
    [EnumMember(Value = "egypt")]
    Egypt,

    /// <summary>
    /// 🇪🇭
    /// </summary>
    [EnumMember(Value = "western_sahara")]
    WesternSahara,

    /// <summary>
    /// 🇪🇷
    /// </summary>
    [EnumMember(Value = "eritrea")]
    Eritrea,

    /// <summary>
    /// 🇪🇸
    /// </summary>
    [EnumMember(Value = "es")]
    Es,

    /// <summary>
    /// 🇪🇹
    /// </summary>
    [EnumMember(Value = "ethiopia")]
    Ethiopia,

    /// <summary>
    /// 🇪🇺
    /// </summary>
    [EnumMember(Value = "eu")]
    Eu,

    /// <summary>
    /// 🇫🇮
    /// </summary>
    [EnumMember(Value = "finland")]
    Finland,

    /// <summary>
    /// 🇫🇯
    /// </summary>
    [EnumMember(Value = "fiji")]
    Fiji,

    /// <summary>
    /// 🇫🇰
    /// </summary>
    [EnumMember(Value = "falkland_islands")]
    FalklandIslands,

    /// <summary>
    /// 🇫🇲
    /// </summary>
    [EnumMember(Value = "micronesia")]
    Micronesia,

    /// <summary>
    /// 🇫🇴
    /// </summary>
    [EnumMember(Value = "faroe_islands")]
    FaroeIslands,

    /// <summary>
    /// 🇫🇷
    /// </summary>
    [EnumMember(Value = "fr")]
    Fr,

    /// <summary>
    /// 🇬🇦
    /// </summary>
    [EnumMember(Value = "gabon")]
    Gabon,

    /// <summary>
    /// 🇬🇧
    /// </summary>
    [EnumMember(Value = "gb")]
    Gb,

    /// <summary>
    /// 🇬🇩
    /// </summary>
    [EnumMember(Value = "grenada")]
    Grenada,

    /// <summary>
    /// 🇬🇪
    /// </summary>
    [EnumMember(Value = "georgia")]
    Georgia,

    /// <summary>
    /// 🇬🇫
    /// </summary>
    [EnumMember(Value = "french_guiana")]
    FrenchGuiana,

    /// <summary>
    /// 🇬🇬
    /// </summary>
    [EnumMember(Value = "guernsey")]
    Guernsey,

    /// <summary>
    /// 🇬🇭
    /// </summary>
    [EnumMember(Value = "ghana")]
    Ghana,

    /// <summary>
    /// 🇬🇮
    /// </summary>
    [EnumMember(Value = "gibraltar")]
    Gibraltar,

    /// <summary>
    /// 🇬🇱
    /// </summary>
    [EnumMember(Value = "greenland")]
    Greenland,

    /// <summary>
    /// 🇬🇲
    /// </summary>
    [EnumMember(Value = "gambia")]
    Gambia,

    /// <summary>
    /// 🇬🇳
    /// </summary>
    [EnumMember(Value = "guinea")]
    Guinea,

    /// <summary>
    /// 🇬🇵
    /// </summary>
    [EnumMember(Value = "guadeloupe")]
    Guadeloupe,

    /// <summary>
    /// 🇬🇶
    /// </summary>
    [EnumMember(Value = "equatorial_guinea")]
    EquatorialGuinea,

    /// <summary>
    /// 🇬🇷
    /// </summary>
    [EnumMember(Value = "greece")]
    Greece,

    /// <summary>
    /// 🇬🇸
    /// </summary>
    [EnumMember(Value = "south_georgia_south_sandwich_islands")]
    SouthGeorgiaSouthSandwichIslands,

    /// <summary>
    /// 🇬🇹
    /// </summary>
    [EnumMember(Value = "guatemala")]
    Guatemala,

    /// <summary>
    /// 🇬🇺
    /// </summary>
    [EnumMember(Value = "guam")]
    Guam,

    /// <summary>
    /// 🇬🇼
    /// </summary>
    [EnumMember(Value = "guinea_bissau")]
    GuineaBissau,

    /// <summary>
    /// 🇬🇾
    /// </summary>
    [EnumMember(Value = "guyana")]
    Guyana,

    /// <summary>
    /// 🇭🇰
    /// </summary>
    [EnumMember(Value = "hong_kong")]
    HongKong,

    /// <summary>
    /// 🇭🇲
    /// </summary>
    [EnumMember(Value = "heard_mcdonald_islands")]
    HeardMcdonaldIslands,

    /// <summary>
    /// 🇭🇳
    /// </summary>
    [EnumMember(Value = "honduras")]
    Honduras,

    /// <summary>
    /// 🇭🇷
    /// </summary>
    [EnumMember(Value = "croatia")]
    Croatia,

    /// <summary>
    /// 🇭🇹
    /// </summary>
    [EnumMember(Value = "haiti")]
    Haiti,

    /// <summary>
    /// 🇭🇺
    /// </summary>
    [EnumMember(Value = "hungary")]
    Hungary,

    /// <summary>
    /// 🇮🇨
    /// </summary>
    [EnumMember(Value = "canary_islands")]
    CanaryIslands,

    /// <summary>
    /// 🇮🇩
    /// </summary>
    [EnumMember(Value = "indonesia")]
    Indonesia,

    /// <summary>
    /// 🇮🇪
    /// </summary>
    [EnumMember(Value = "ireland")]
    Ireland,

    /// <summary>
    /// 🇮🇱
    /// </summary>
    [EnumMember(Value = "israel")]
    Israel,

    /// <summary>
    /// 🇮🇲
    /// </summary>
    [EnumMember(Value = "isle_of_man")]
    IsleOfMan,

    /// <summary>
    /// 🇮🇳
    /// </summary>
    [EnumMember(Value = "india")]
    India,

    /// <summary>
    /// 🇮🇴
    /// </summary>
    [EnumMember(Value = "british_indian_ocean_territory")]
    BritishIndianOceanTerritory,

    /// <summary>
    /// 🇮🇶
    /// </summary>
    [EnumMember(Value = "iraq")]
    Iraq,

    /// <summary>
    /// 🇮🇷
    /// </summary>
    [EnumMember(Value = "iran")]
    Iran,

    /// <summary>
    /// 🇮🇸
    /// </summary>
    [EnumMember(Value = "iceland")]
    Iceland,

    /// <summary>
    /// 🇮🇹
    /// </summary>
    [EnumMember(Value = "it")]
    It,

    /// <summary>
    /// 🇯🇪
    /// </summary>
    [EnumMember(Value = "jersey")]
    Jersey,

    /// <summary>
    /// 🇯🇲
    /// </summary>
    [EnumMember(Value = "jamaica")]
    Jamaica,

    /// <summary>
    /// 🇯🇴
    /// </summary>
    [EnumMember(Value = "jordan")]
    Jordan,

    /// <summary>
    /// 🇯🇵
    /// </summary>
    [EnumMember(Value = "jp")]
    Jp,

    /// <summary>
    /// 🇰🇪
    /// </summary>
    [EnumMember(Value = "kenya")]
    Kenya,

    /// <summary>
    /// 🇰🇬
    /// </summary>
    [EnumMember(Value = "kyrgyzstan")]
    Kyrgyzstan,

    /// <summary>
    /// 🇰🇭
    /// </summary>
    [EnumMember(Value = "cambodia")]
    Cambodia,

    /// <summary>
    /// 🇰🇮
    /// </summary>
    [EnumMember(Value = "kiribati")]
    Kiribati,

    /// <summary>
    /// 🇰🇲
    /// </summary>
    [EnumMember(Value = "comoros")]
    Comoros,

    /// <summary>
    /// 🇰🇳
    /// </summary>
    [EnumMember(Value = "st_kitts_nevis")]
    StKittsNevis,

    /// <summary>
    /// 🇰🇵
    /// </summary>
    [EnumMember(Value = "north_korea")]
    NorthKorea,

    /// <summary>
    /// 🇰🇷
    /// </summary>
    [EnumMember(Value = "kr")]
    Kr,

    /// <summary>
    /// 🇰🇼
    /// </summary>
    [EnumMember(Value = "kuwait")]
    Kuwait,

    /// <summary>
    /// 🇰🇾
    /// </summary>
    [EnumMember(Value = "cayman_islands")]
    CaymanIslands,

    /// <summary>
    /// 🇰🇿
    /// </summary>
    [EnumMember(Value = "kazakhstan")]
    Kazakhstan,

    /// <summary>
    /// 🇱🇦
    /// </summary>
    [EnumMember(Value = "laos")]
    Laos,

    /// <summary>
    /// 🇱🇧
    /// </summary>
    [EnumMember(Value = "lebanon")]
    Lebanon,

    /// <summary>
    /// 🇱🇨
    /// </summary>
    [EnumMember(Value = "st_lucia")]
    StLucia,

    /// <summary>
    /// 🇱🇮
    /// </summary>
    [EnumMember(Value = "liechtenstein")]
    Liechtenstein,

    /// <summary>
    /// 🇱🇰
    /// </summary>
    [EnumMember(Value = "sri_lanka")]
    SriLanka,

    /// <summary>
    /// 🇱🇷
    /// </summary>
    [EnumMember(Value = "liberia")]
    Liberia,

    /// <summary>
    /// 🇱🇸
    /// </summary>
    [EnumMember(Value = "lesotho")]
    Lesotho,

    /// <summary>
    /// 🇱🇹
    /// </summary>
    [EnumMember(Value = "lithuania")]
    Lithuania,

    /// <summary>
    /// 🇱🇺
    /// </summary>
    [EnumMember(Value = "luxembourg")]
    Luxembourg,

    /// <summary>
    /// 🇱🇻
    /// </summary>
    [EnumMember(Value = "latvia")]
    Latvia,

    /// <summary>
    /// 🇱🇾
    /// </summary>
    [EnumMember(Value = "libya")]
    Libya,

    /// <summary>
    /// 🇲🇦
    /// </summary>
    [EnumMember(Value = "morocco")]
    Morocco,

    /// <summary>
    /// 🇲🇨
    /// </summary>
    [EnumMember(Value = "monaco")]
    Monaco,

    /// <summary>
    /// 🇲🇩
    /// </summary>
    [EnumMember(Value = "moldova")]
    Moldova,

    /// <summary>
    /// 🇲🇪
    /// </summary>
    [EnumMember(Value = "montenegro")]
    Montenegro,

    /// <summary>
    /// 🇲🇫
    /// </summary>
    [EnumMember(Value = "st_martin")]
    StMartin,

    /// <summary>
    /// 🇲🇬
    /// </summary>
    [EnumMember(Value = "madagascar")]
    Madagascar,

    /// <summary>
    /// 🇲🇭
    /// </summary>
    [EnumMember(Value = "marshall_islands")]
    MarshallIslands,

    /// <summary>
    /// 🇲🇰
    /// </summary>
    [EnumMember(Value = "macedonia")]
    Macedonia,

    /// <summary>
    /// 🇲🇱
    /// </summary>
    [EnumMember(Value = "mali")]
    Mali,

    /// <summary>
    /// 🇲🇲
    /// </summary>
    [EnumMember(Value = "myanmar")]
    Myanmar,

    /// <summary>
    /// 🇲🇳
    /// </summary>
    [EnumMember(Value = "mongolia")]
    Mongolia,

    /// <summary>
    /// 🇲🇴
    /// </summary>
    [EnumMember(Value = "macau")]
    Macau,

    /// <summary>
    /// 🇲🇵
    /// </summary>
    [EnumMember(Value = "northern_mariana_islands")]
    NorthernMarianaIslands,

    /// <summary>
    /// 🇲🇶
    /// </summary>
    [EnumMember(Value = "martinique")]
    Martinique,

    /// <summary>
    /// 🇲🇷
    /// </summary>
    [EnumMember(Value = "mauritania")]
    Mauritania,

    /// <summary>
    /// 🇲🇸
    /// </summary>
    [EnumMember(Value = "montserrat")]
    Montserrat,

    /// <summary>
    /// 🇲🇹
    /// </summary>
    [EnumMember(Value = "malta")]
    Malta,

    /// <summary>
    /// 🇲🇺
    /// </summary>
    [EnumMember(Value = "mauritius")]
    Mauritius,

    /// <summary>
    /// 🇲🇻
    /// </summary>
    [EnumMember(Value = "maldives")]
    Maldives,

    /// <summary>
    /// 🇲🇼
    /// </summary>
    [EnumMember(Value = "malawi")]
    Malawi,

    /// <summary>
    /// 🇲🇽
    /// </summary>
    [EnumMember(Value = "mexico")]
    Mexico,

    /// <summary>
    /// 🇲🇾
    /// </summary>
    [EnumMember(Value = "malaysia")]
    Malaysia,

    /// <summary>
    /// 🇲🇿
    /// </summary>
    [EnumMember(Value = "mozambique")]
    Mozambique,

    /// <summary>
    /// 🇳🇦
    /// </summary>
    [EnumMember(Value = "namibia")]
    Namibia,

    /// <summary>
    /// 🇳🇨
    /// </summary>
    [EnumMember(Value = "new_caledonia")]
    NewCaledonia,

    /// <summary>
    /// 🇳🇪
    /// </summary>
    [EnumMember(Value = "niger")]
    Niger,

    /// <summary>
    /// 🇳🇫
    /// </summary>
    [EnumMember(Value = "norfolk_island")]
    NorfolkIsland,

    /// <summary>
    /// 🇳🇬
    /// </summary>
    [EnumMember(Value = "nigeria")]
    Nigeria,

    /// <summary>
    /// 🇳🇮
    /// </summary>
    [EnumMember(Value = "nicaragua")]
    Nicaragua,

    /// <summary>
    /// 🇳🇱
    /// </summary>
    [EnumMember(Value = "netherlands")]
    Netherlands,

    /// <summary>
    /// 🇳🇴
    /// </summary>
    [EnumMember(Value = "norway")]
    Norway,

    /// <summary>
    /// 🇳🇵
    /// </summary>
    [EnumMember(Value = "nepal")]
    Nepal,

    /// <summary>
    /// 🇳🇷
    /// </summary>
    [EnumMember(Value = "nauru")]
    Nauru,

    /// <summary>
    /// 🇳🇺
    /// </summary>
    [EnumMember(Value = "niue")]
    Niue,

    /// <summary>
    /// 🇳🇿
    /// </summary>
    [EnumMember(Value = "new_zealand")]
    NewZealand,

    /// <summary>
    /// 🇴🇲
    /// </summary>
    [EnumMember(Value = "oman")]
    Oman,

    /// <summary>
    /// 🇵🇦
    /// </summary>
    [EnumMember(Value = "panama")]
    Panama,

    /// <summary>
    /// 🇵🇪
    /// </summary>
    [EnumMember(Value = "peru")]
    Peru,

    /// <summary>
    /// 🇵🇫
    /// </summary>
    [EnumMember(Value = "french_polynesia")]
    FrenchPolynesia,

    /// <summary>
    /// 🇵🇬
    /// </summary>
    [EnumMember(Value = "papua_new_guinea")]
    PapuaNewGuinea,

    /// <summary>
    /// 🇵🇭
    /// </summary>
    [EnumMember(Value = "philippines")]
    Philippines,

    /// <summary>
    /// 🇵🇰
    /// </summary>
    [EnumMember(Value = "pakistan")]
    Pakistan,

    /// <summary>
    /// 🇵🇱
    /// </summary>
    [EnumMember(Value = "poland")]
    Poland,

    /// <summary>
    /// 🇵🇲
    /// </summary>
    [EnumMember(Value = "st_pierre_miquelon")]
    StPierreMiquelon,

    /// <summary>
    /// 🇵🇳
    /// </summary>
    [EnumMember(Value = "pitcairn_islands")]
    PitcairnIslands,

    /// <summary>
    /// 🇵🇷
    /// </summary>
    [EnumMember(Value = "puerto_rico")]
    PuertoRico,

    /// <summary>
    /// 🇵🇸
    /// </summary>
    [EnumMember(Value = "palestinian_territories")]
    PalestinianTerritories,

    /// <summary>
    /// 🇵🇹
    /// </summary>
    [EnumMember(Value = "portugal")]
    Portugal,

    /// <summary>
    /// 🇵🇼
    /// </summary>
    [EnumMember(Value = "palau")]
    Palau,

    /// <summary>
    /// 🇵🇾
    /// </summary>
    [EnumMember(Value = "paraguay")]
    Paraguay,

    /// <summary>
    /// 🇶🇦
    /// </summary>
    [EnumMember(Value = "qatar")]
    Qatar,

    /// <summary>
    /// 🇷🇪
    /// </summary>
    [EnumMember(Value = "reunion")]
    Reunion,

    /// <summary>
    /// 🇷🇴
    /// </summary>
    [EnumMember(Value = "romania")]
    Romania,

    /// <summary>
    /// 🇷🇸
    /// </summary>
    [EnumMember(Value = "serbia")]
    Serbia,

    /// <summary>
    /// 🇷🇺
    /// </summary>
    [EnumMember(Value = "ru")]
    Ru,

    /// <summary>
    /// 🇷🇼
    /// </summary>
    [EnumMember(Value = "rwanda")]
    Rwanda,

    /// <summary>
    /// 🇸🇦
    /// </summary>
    [EnumMember(Value = "saudi_arabia")]
    SaudiArabia,

    /// <summary>
    /// 🇸🇧
    /// </summary>
    [EnumMember(Value = "solomon_islands")]
    SolomonIslands,

    /// <summary>
    /// 🇸🇨
    /// </summary>
    [EnumMember(Value = "seychelles")]
    Seychelles,

    /// <summary>
    /// 🇸🇩
    /// </summary>
    [EnumMember(Value = "sudan")]
    Sudan,

    /// <summary>
    /// 🇸🇪
    /// </summary>
    [EnumMember(Value = "sweden")]
    Sweden,

    /// <summary>
    /// 🇸🇬
    /// </summary>
    [EnumMember(Value = "singapore")]
    Singapore,

    /// <summary>
    /// 🇸🇭
    /// </summary>
    [EnumMember(Value = "st_helena")]
    StHelena,

    /// <summary>
    /// 🇸🇮
    /// </summary>
    [EnumMember(Value = "slovenia")]
    Slovenia,

    /// <summary>
    /// 🇸🇯
    /// </summary>
    [EnumMember(Value = "svalbard_jan_mayen")]
    SvalbardJanMayen,

    /// <summary>
    /// 🇸🇰
    /// </summary>
    [EnumMember(Value = "slovakia")]
    Slovakia,

    /// <summary>
    /// 🇸🇱
    /// </summary>
    [EnumMember(Value = "sierra_leone")]
    SierraLeone,

    /// <summary>
    /// 🇸🇲
    /// </summary>
    [EnumMember(Value = "san_marino")]
    SanMarino,

    /// <summary>
    /// 🇸🇳
    /// </summary>
    [EnumMember(Value = "senegal")]
    Senegal,

    /// <summary>
    /// 🇸🇴
    /// </summary>
    [EnumMember(Value = "somalia")]
    Somalia,

    /// <summary>
    /// 🇸🇷
    /// </summary>
    [EnumMember(Value = "suriname")]
    Suriname,

    /// <summary>
    /// 🇸🇸
    /// </summary>
    [EnumMember(Value = "south_sudan")]
    SouthSudan,

    /// <summary>
    /// 🇸🇹
    /// </summary>
    [EnumMember(Value = "sao_tome_principe")]
    SaoTomePrincipe,

    /// <summary>
    /// 🇸🇻
    /// </summary>
    [EnumMember(Value = "el_salvador")]
    ElSalvador,

    /// <summary>
    /// 🇸🇽
    /// </summary>
    [EnumMember(Value = "sint_maarten")]
    SintMaarten,

    /// <summary>
    /// 🇸🇾
    /// </summary>
    [EnumMember(Value = "syria")]
    Syria,

    /// <summary>
    /// 🇸🇿
    /// </summary>
    [EnumMember(Value = "swaziland")]
    Swaziland,

    /// <summary>
    /// 🇹🇦
    /// </summary>
    [EnumMember(Value = "tristan_da_cunha")]
    TristanDaCunha,

    /// <summary>
    /// 🇹🇨
    /// </summary>
    [EnumMember(Value = "turks_caicos_islands")]
    TurksCaicosIslands,

    /// <summary>
    /// 🇹🇩
    /// </summary>
    [EnumMember(Value = "chad")]
    Chad,

    /// <summary>
    /// 🇹🇫
    /// </summary>
    [EnumMember(Value = "french_southern_territories")]
    FrenchSouthernTerritories,

    /// <summary>
    /// 🇹🇬
    /// </summary>
    [EnumMember(Value = "togo")]
    Togo,

    /// <summary>
    /// 🇹🇭
    /// </summary>
    [EnumMember(Value = "thailand")]
    Thailand,

    /// <summary>
    /// 🇹🇯
    /// </summary>
    [EnumMember(Value = "tajikistan")]
    Tajikistan,

    /// <summary>
    /// 🇹🇰
    /// </summary>
    [EnumMember(Value = "tokelau")]
    Tokelau,

    /// <summary>
    /// 🇹🇱
    /// </summary>
    [EnumMember(Value = "timor_leste")]
    TimorLeste,

    /// <summary>
    /// 🇹🇲
    /// </summary>
    [EnumMember(Value = "turkmenistan")]
    Turkmenistan,

    /// <summary>
    /// 🇹🇳
    /// </summary>
    [EnumMember(Value = "tunisia")]
    Tunisia,

    /// <summary>
    /// 🇹🇴
    /// </summary>
    [EnumMember(Value = "tonga")]
    Tonga,

    /// <summary>
    /// 🇹🇷
    /// </summary>
    [EnumMember(Value = "tr")]
    Tr,

    /// <summary>
    /// 🇹🇹
    /// </summary>
    [EnumMember(Value = "trinidad_tobago")]
    TrinidadTobago,

    /// <summary>
    /// 🇹🇻
    /// </summary>
    [EnumMember(Value = "tuvalu")]
    Tuvalu,

    /// <summary>
    /// 🇹🇼
    /// </summary>
    [EnumMember(Value = "taiwan")]
    Taiwan,

    /// <summary>
    /// 🇹🇿
    /// </summary>
    [EnumMember(Value = "tanzania")]
    Tanzania,

    /// <summary>
    /// 🇺🇦
    /// </summary>
    [EnumMember(Value = "ukraine")]
    Ukraine,

    /// <summary>
    /// 🇺🇬
    /// </summary>
    [EnumMember(Value = "uganda")]
    Uganda,

    /// <summary>
    /// 🇺🇲
    /// </summary>
    [EnumMember(Value = "us_outlying_islands")]
    UsOutlyingIslands,

    /// <summary>
    /// 🇺🇳
    /// </summary>
    [EnumMember(Value = "united_nations")]
    UnitedNations,

    /// <summary>
    /// 🇺🇸
    /// </summary>
    [EnumMember(Value = "us")]
    Us,

    /// <summary>
    /// 🇺🇾
    /// </summary>
    [EnumMember(Value = "uruguay")]
    Uruguay,

    /// <summary>
    /// 🇺🇿
    /// </summary>
    [EnumMember(Value = "uzbekistan")]
    Uzbekistan,

    /// <summary>
    /// 🇻🇦
    /// </summary>
    [EnumMember(Value = "vatican_city")]
    VaticanCity,

    /// <summary>
    /// 🇻🇨
    /// </summary>
    [EnumMember(Value = "st_vincent_grenadines")]
    StVincentGrenadines,

    /// <summary>
    /// 🇻🇪
    /// </summary>
    [EnumMember(Value = "venezuela")]
    Venezuela,

    /// <summary>
    /// 🇻🇬
    /// </summary>
    [EnumMember(Value = "british_virgin_islands")]
    BritishVirginIslands,

    /// <summary>
    /// 🇻🇮
    /// </summary>
    [EnumMember(Value = "us_virgin_islands")]
    UsVirginIslands,

    /// <summary>
    /// 🇻🇳
    /// </summary>
    [EnumMember(Value = "vietnam")]
    Vietnam,

    /// <summary>
    /// 🇻🇺
    /// </summary>
    [EnumMember(Value = "vanuatu")]
    Vanuatu,

    /// <summary>
    /// 🇼🇫
    /// </summary>
    [EnumMember(Value = "wallis_futuna")]
    WallisFutuna,

    /// <summary>
    /// 🇼🇸
    /// </summary>
    [EnumMember(Value = "samoa")]
    Samoa,

    /// <summary>
    /// 🇽🇰
    /// </summary>
    [EnumMember(Value = "kosovo")]
    Kosovo,

    /// <summary>
    /// 🇾🇪
    /// </summary>
    [EnumMember(Value = "yemen")]
    Yemen,

    /// <summary>
    /// 🇾🇹
    /// </summary>
    [EnumMember(Value = "mayotte")]
    Mayotte,

    /// <summary>
    /// 🇿🇦
    /// </summary>
    [EnumMember(Value = "south_africa")]
    SouthAfrica,

    /// <summary>
    /// 🇿🇲
    /// </summary>
    [EnumMember(Value = "zambia")]
    Zambia,

    /// <summary>
    /// 🇿🇼
    /// </summary>
    [EnumMember(Value = "zimbabwe")]
    Zimbabwe,

    /// <summary>
    /// 🏴󠁧󠁢󠁥󠁮󠁧󠁿
    /// </summary>
    [EnumMember(Value = "england")]
    England,

    /// <summary>
    /// 🏴󠁧󠁢󠁳󠁣󠁴󠁿
    /// </summary>
    [EnumMember(Value = "scotland")]
    Scotland,

    /// <summary>
    /// 🏴󠁧󠁢󠁷󠁬󠁳󠁿
    /// </summary>
    [EnumMember(Value = "wales")]
    Wales
}
