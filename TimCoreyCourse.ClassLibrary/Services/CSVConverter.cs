namespace TimCoreyCourse.ClassLibrary.Services
{
    public class CSVConverter<T> where T : new()
    {
        public event EventHandler<T> NameContains1;

        public void OutputAsCSV(List<T> items)
        {
            var obj = new T();
            var cols = obj.GetType().GetProperties();
            List<string> rows = new List<string>();

            string rowText = "";
            string value = "";

            foreach (var col in cols)
            {
                rowText += $"{col.Name},";
            }
            rows.Add(rowText);
            rowText = "";

            foreach (var item in items)
            {
                foreach (var col in cols)
                {
                    value = $"{col.GetValue(item)},";
                    if (value.Contains("1")) NameContains1?.Invoke(this, item);
                    rowText += value;
                }
                rows.Add(rowText);
                rowText = "";
            }

            Console.WriteLine();
            foreach (string row in rows) Console.WriteLine(row);
        }
    }
}
