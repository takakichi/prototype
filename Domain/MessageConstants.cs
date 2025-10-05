using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPrototype.Domain
{
    internal class MessageConstants
    {
        // エラー系メッセージ
        public const string ErrorSaveFailed = "保存に失敗しました。";
        public const string ErrorLoadFailed = "読込に失敗しました。";
        public const string ErrorInvalidInput = "入力値が不正です。";

        // 情報系メッセージ
        public const string InfoSaved = "保存しました。";
        public const string InfoLoaded = "読込が完了しました。";

        // 確認系メッセージ
        public const string ConfirmAddNew = "追加してもよろしいですか？";
        public const string ConfirmDelete = "削除してもよろしいですか？";
        public const string ConfirmExit = "終了してもよろしいですか？";
    }
}
