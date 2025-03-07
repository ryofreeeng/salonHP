﻿using System;
using System.ComponentModel.DataAnnotations;


namespace Therapim.Models
{
    /// <summary>
    /// 予約用リクエスト情報
    /// </summary>
    using System;
    using System.ComponentModel.DataAnnotations;
    using Therapim.Filters;

    public class ReservationRequestModel
    {
        // userId　画面にない項目のため、Required属性はつけずにアクションメソッド内で手動バリデーション実行する        
        [StringLength(100, ErrorMessage = "ユーザIDの桁数が超過しています☆こちらは入力項目ではないため、お手数ですがもう一度ログインからやり直してください")]
        public string? UserId { get; set; }

        // お名前 (必須、最大50文字)
        [Required(ErrorMessage = "お名前をご入力ください☆")]
        [StringLength(50, ErrorMessage = "お名前は50文字以内で入力してください☆")]
        public string FullName { get; set; }

        // 電話番号 (必須)
        [Required(ErrorMessage = "電話番号をご入力ください☆")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "お電話番号は10～12桁でご入力ください☆")]
        public string PhoneNumber { get; set; }

        // 生年月日 (必須)
        [Required(ErrorMessage = "生年月日をご入力ください☆")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "生年月日は西暦を含めて8桁でご入力ください☆")]
        public string Birthday { get; set; }

        // メールアドレス (必須、メール形式)
        [Required(ErrorMessage = "メールアドレスをご入力ください☆")]
        [EmailAddress(ErrorMessage = "正しいメールアドレス形式で入力してください☆")]
        public string MailAddress { get; set; }

        // 性別 (必須)
        [Required(ErrorMessage = "性別をご選択ください☆")]
        public string Gender { get; set; }

        // SNS名 (任意、最大50文字)
        [StringLength(50, ErrorMessage = "SNS名は50文字以内で入力してください☆")]
        public string? SnsName { get; set; }

        // メニューID (必須)
        [Required(ErrorMessage = "メニューを選択してください☆")]
        public int MenuId { get; set; }

        // メニュー表示名 (必須)        
        public string? CourseNameDisp { get; set; }

        // メニューオプションID (任意)
        public int? CourseOptionId { get; set; }

        // メニューオプション (任意)
        public string? CourseOption { get; set; }

        // オプション1選択 (必須)
        [Required(ErrorMessage = "オプション1を選択してください☆")]
        public string PaperBraSelect { get; set; }

        // オプション2選択 (必須)
        [Required(ErrorMessage = "オプション2を選択してください☆")]
        public string PaperPantsSelect { get; set; }

        // オプション3選択 (必須)
        [Required(ErrorMessage = "オプション3を選択してください☆")]
        public string AromaOilSelect { get; set; }

        // お届け希望 (必須)
        [Required(ErrorMessage = "お届け希望の値が不正です☆")]
        public bool IsVisit { get; set; }

        // 希望出張先概要 (必須)
        [Display(Name = "出張先の概要")]
        [RequiredIfTrue("IsVisit")]
        [StringLength(200, ErrorMessage = "出張先の概要は100文字以内で入力してください☆")]
        public string? DesiredVisitPlace { get; set; }

        // 住所 (必須、最大200文字)
        [Display(Name = "住所")]
        [StringLength(200, ErrorMessage = "住所は200文字以内で入力してください☆")]
        public string? Address { get; set; }

        // 希望店舗 (必須)
        [Display(Name = "希望店舗")]
        [RequiredIfFalse("IsVisit")]
        public string? DesiredSalon { get; set; }

        // 第1希望日時 開始・終了 (必須)
        [Display(Name = "第1希望の開始日時")]
        [Required(ErrorMessage = "第1希望の開始日時をご選択ください☆")]
        public DateTime? DesiredDateTimeStart1 { get; set; }
        
        [Display(Name = "第1希望の終了日時")]
        [Required(ErrorMessage = "第1希望の終了時刻をご選択ください☆")]
        public DateTime? DesiredDateTimeEnd1 { get; set; }

        // 第2希望日時 開始・終了 (任意)
        public DateTime? DesiredDateTimeStart2 { get; set; }
        public DateTime? DesiredDateTimeEnd2 { get; set; }

        // 第3希望日時 開始・終了 (任意)
        public DateTime? DesiredDateTimeStart3 { get; set; }
        public DateTime? DesiredDateTimeEnd3 { get; set; }

        // 会話希望 (任意、最大500文字)
        [StringLength(500, ErrorMessage = "お届け方法に関するご要望は500文字以内で入力してください☆")]
        public string? Conversation { get; set; }

        // お届け時間帯 (任意、最大500文字)
        [StringLength(500, ErrorMessage = "お届け時間帯は500文字以内で入力してください☆")]
        public string? NotTouchParts { get; set; }

        // その他要望 (任意、最大1000文字)
        [StringLength(1000, ErrorMessage = "その他要望は1000文字以内で入力してください☆")]
        public string? OtherRequest { get; set; }

        // 補足事項 (任意、最大1000文字)
        [StringLength(1000, ErrorMessage = "補足事項は1000文字以内で入力してください☆")]
        public string? OtherThings { get; set; }

        //登録セッションID
        public string? CreatedSessionId { get; set; }

    }

}
