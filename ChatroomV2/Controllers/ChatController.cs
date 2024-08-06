using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace ChatroomV2.Controllers
{
    public class ChatController
    {
        
        public HubConnection hubConnection;

        public async void InitAsync()
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7257/chatHub")
                .Build();
            
            hubConnection.Closed += HubConnection_Closed;
        }

        private async Task HubConnection_Closed(Exception arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await hubConnection.StartAsync();
        }


        public async Task OnLoadAsync(ListBox messageBox)
        {
            // Create a new HubConnection
            hubConnection.On<string, string>("ReceiveMessage", async (user, message) =>
            {
                string decryptedMessage = await EncryptionController.DecryptMessage(message, ChatWindow.key, ChatWindow.iv);

                string newMessage = $"{user}: {decryptedMessage}";

                // Add the decrypted message to the messageBox
                messageBox.Items.Add(newMessage);
            });

            // Start the connection
            try
            {
                await hubConnection.StartAsync();
                messageBox.Items.Add("Connection Established!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task SendMessageAsync(string user, string message) 
        {
            try
            {
                // Encrypt the message before sending it
                var encryptedMessage = await EncryptionController.EncryptMessage(message, ChatWindow.key, ChatWindow.iv);

                // Send the message to the server
                await hubConnection.InvokeAsync("SendMessage", user, encryptedMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
