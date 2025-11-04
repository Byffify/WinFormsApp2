using System;

namespace WinFormsApp2
{
    // อนุสัญญา: A = E (Extrovert), B = I (Introvert)
    public class QuizState
    {
        public char?[] Answers { get; }   // เก็บคำตอบรายข้อ: 'A' | 'B' | null
        public int CountE { get; private set; }  // รวมฝั่ง A
        public int CountI { get; private set; }  // รวมฝั่ง B

        public QuizState(int totalQuestions)
        {
            if (totalQuestions <= 0) throw new ArgumentOutOfRangeException(nameof(totalQuestions));
            Answers = new char?[totalQuestions];
        }

        /// <summary>
        /// เซ็ตคำตอบของข้อที่ index (0..N-1) และจัดการหัก/บวกคะแนนให้ถูกต้อง
        /// </summary>
        public void SetAnswer(int index, char? choice)
        {
            if (index < 0 || index >= Answers.Length)
                throw new IndexOutOfRangeException();

            var prev = Answers[index];

            // ถอนคะแนนของคำตอบเดิม (ถ้ามี)
            if (prev == 'A') CountE--;
            if (prev == 'B') CountI--;

            // บันทึกคำตอบใหม่
            Answers[index] = choice;

            // เติมคะแนนให้คำตอบใหม่
            if (choice == 'A') CountE++;
            else if (choice == 'B') CountI++;
        }

        /// <summary>
        /// สรุปผลรวมแบบสั้น ๆ
        /// </summary>
        public string Summary()
        {
            string dom = CountE > CountI ? "พลัง E เด่นกว่า"
                       : CountI > CountE ? "พลัง I เด่นกว่า"
                       : "สมดุล E = I";
            return $"E(A) = {CountE}, I(B) = {CountI} → {dom}";
        }
    }
}
