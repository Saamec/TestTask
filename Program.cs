using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using TestTask.BLL;
using TestTask.Veiw;

List<string> fileValue = new List<string>();

StartDialog startDialog = new StartDialog();
startDialog.CheckDirection();
var dir = startDialog.fileDirection;

if (dir != "" && File.Exists(dir) && dir.Contains(".csv"))
fileValue = FileReader.Reader(startDialog.fileDirection, fileValue);

//fileValue = FileReader.Reader("C:\\Users\\Admin\\Desktop\\Показания.csv", fileValue);

var EntityList = FileEntityParser.Parser(fileValue);

FinalDataSheetView.Show(EntityList);

FileWriter.Writer(dir.Substring(0, dir.Length - 4) + "_new.csv", EntityList);

СonsumerСhecker.Check(EntityList);

