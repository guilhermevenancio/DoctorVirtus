using Android.App;
using System;
using System.Threading.Tasks;

[Service(Exported = true)]
public class AtualizacaoService : Service {
    
    public override void OnCreate() {
        base.OnCreate();
    }

    public override StartCommandResult OnStartCommand(Android.Content.Intent intent, StartCommandFlags flags, int startId) {
        try {
            Atualizar();
            return StartCommandResult.Sticky;
        } catch (Exception ex) {
            Console.Write(ex.Message);
            return StartCommandResult.Sticky;
        }
        
    }

    public override Android.OS.IBinder OnBind(Android.Content.Intent intent) {
        return null;
    }

    public override void OnDestroy() {
        base.OnDestroy();
    }

    private async void Atualizar() {
        try {
            while (true) {
                
                await DoctorVirtus.Aplicativo.Services.AtualizacaoService.Atualizar();

                await Task.Delay(1000 * 60 * 5); //Atualiza a cada 10 minutos

            }
        } catch (Exception ex) {
            Console.Write(ex.Message);
        } 
    }
}

