using ApprovalTests;
using SudokuKata;
namespace SudokuKata.Tests;

public class ApprovalShould
{
    const string SUDOKU_OUTPUT_FILE_NAME= "./SudokuOutput.txt";
    [Fact]
    public void VerifySudokuOutput()
    {
        var output = Program.Play();
        using (var writer = new StreamWriter(SUDOKU_OUTPUT_FILE_NAME))
        writer.Write(output);
        Approvals.Verify(output);
    }
}