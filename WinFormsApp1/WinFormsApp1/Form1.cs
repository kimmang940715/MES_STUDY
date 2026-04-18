using System;
using System.Data;
using System.Data.SqlClient; // MSSQL 연결을 위해 반드시 추가해야 하는 네임스페이스
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // '조회' 버튼을 눌렀을 때 실행되는 이벤트
        private void button2_Click(object sender, EventArgs e)
        {
            // 1. 방금 성공하신 그 완벽한 연결 문자열
            string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=MESDB; Integrated Security=True;";

            // 2. 실행할 쿼리문 (본인이 만든 테이블 이름으로 바꿔주세요!)
            // 예: "SELECT * FROM Carts" 또는 "SELECT * FROM RentalHistory"
            string query = "SELECT * FROM LOT_STS";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 3. DB와 C# 프로그램을 이어주는 다리(Adapter) 생성
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // 4. 데이터를 담을 빈 바구니(DataTable) 생성
                    DataTable dataTable = new DataTable();

                    // 5. DB에서 데이터를 긁어와서 바구니(dataTable)에 쏟아붓기
                    adapter.Fill(dataTable);

                    // 6. 꽉 찬 바구니를 화면의 DataGridView에 연결 (자동으로 표가 그려집니다)
                    // 주의: 화면에 만드신 그리드 이름이 dataGridView1이 맞는지 확인하세요!
                    dataGridView1.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 조회 중 오류가 발생했습니다.\n\n에러 내용: " + ex.Message,
                                    "조회 실패",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            } // using 블록 종료 시 DB 연결이 자동으로 닫힙니다 (안전)
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}