using System;

namespace WinFormsApp2
{
    public static class AppState
    {
        // โฮลเดอร์สถานะแบบทดสอบตัวเดียวทั้งแอป
        public static QuizState State { get; private set; } =
            new QuizState(QuizData.Questions.Length);

        // ใช้รีเซ็ตใหม่เวลาจะเริ่มแบบทดสอบอีกรอบ
        public static void Reset()
        {
            State = new QuizState(QuizData.Questions.Length);
        }
    }
}
