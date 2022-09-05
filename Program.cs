using Veiculos;

int cmd = -1;
List<Veiculo> lVeiculos = new List<Veiculo>();

void w(string msg) {
    Console.WriteLine(msg);
}
void wnl(string msg) {
    Console.Write(msg);
}
string r(string msg) {
    wnl(msg);
    return Console.ReadLine();
}
void c() {
    Console.Clear();
}

void showMenu() {
    c();
    w("##################################################");
    w("#                                                #");
    w("#  Sistema de Estacionamento para o DIO          #");
    w("#                                                #");
    w("#      1 - Cadastrar veículo                     #");
    w("#                                                #");
    w("#      2 - Listar Veículos                       #");
    w("#                                                #");
    w("#      3 - Sair                                  #");
    w("#                                                #");
    w("##################################################");
}

void cadastrarVeiculo() {
    c();
    w("==================================================");
    string modelo = r("# Modelo do veículo> ");
    string dono = r("# Dono do veículo> ");
    Veiculo v = new Veiculo();
    v.dono = dono;
    v.modelo = modelo;
    v.datahora = DateTime.Now;
    lVeiculos.Add(v);
    w("|  Veículo cadastrado . ");
    w("==================================================");
    cmd = -1;
}

void listarVeiculos() {
    c();
    w("==================================================");
    for (int i = 0; i < lVeiculos.Count; i++) {
        Veiculo v = lVeiculos[i];
        w($"|   {i} - {v.modelo} - {v.dono}");
    }
    w("==================================================");
    cmd = int.Parse(r("-1 para voltar> "));
    if (cmd >= 0 && cmd < lVeiculos.Count) {
        DateTime dtf = DateTime.Now;
        Veiculo v1 = lVeiculos[cmd];
        DateTime dti = v1.datahora;
        TimeSpan dtr = dtf.Subtract(dti);
        c();
        w("==================================================");
        w($"| {v1.modelo} ");
        w($"| {v1.dono} ");
        w($"| {dtr.Hours}:{dtr.Minutes}:{dtr.Seconds}");
        w("==================================================");
        r("ENTER para continuar.");
        cmd = -1;
    }
}

void main() {
    while (cmd != 3) {
        if (cmd == 1) {
            cadastrarVeiculo();
        }
        if (cmd == 2) {
            listarVeiculos();
        }

        showMenu();
        Console.Write("#> ");
        cmd = int.Parse(Console.ReadLine());
    }
}








// EXECUTANDO PROGRAMA
main();