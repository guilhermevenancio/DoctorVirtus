using Acr.UserDialogs;

namespace DoctorVirtus.Aplicativo.Plugins {
    public static class Loading {

        public static void Show(string message = "") {
            UserDialogs.Instance.ShowLoading(message, MaskType.Black);// .Loading("Carregando...", maskType: MaskType.Black);
        }
        public static void Hide() {
            UserDialogs.Instance.HideLoading();
        }
    }
}

