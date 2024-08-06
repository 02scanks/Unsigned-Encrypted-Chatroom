using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

public class FileController 
{
    internal static Image GetProfilePicture(OpenFileDialog openFileDialog) 
    {
        // set the filter to only show image files
        openFileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg";

        // if the user selects a file
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // get the file path of the image
            string filePath = openFileDialog.FileName;
            // create a new image object from the file path
            Image image = Image.FromFile(filePath);

            // return the image
            if (image != null) return image;
        }

        // return null if no image is selected
        return null;
    }

    internal static async Task<byte[]> ConvertToByteArrayASync(string imagePath) 
    {
        if (imagePath != null) 
        {
            byte[] imageData = File.ReadAllBytes(imagePath);
            return imageData;
        }

        return null;
    }
}