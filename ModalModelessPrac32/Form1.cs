using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModelessPrac32
{
    public partial class Form1 : Form
    {
        // 속성을 덮어쓴 것
        class CustomForm : Form
        {
            public CustomForm()
            {
                this.Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 순서대로 뜬다
            // 모달창 말고 다른 것은 클릭 불가
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");

            DialogResult result;
            // 사용자한테 입력 받기
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Cancel); //반복 시키라는 뜻

            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("사용자가 취소하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
