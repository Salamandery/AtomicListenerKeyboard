# 🧩 AtomicListener

<p align="center">
  <img src="https://img.shields.io/badge/.NET-4.0-blue?logo=dotnet" alt=".NET Framework"/>
  <img src="https://img.shields.io/badge/Platform-Windows-lightgrey?logo=windows" alt="Platform"/>
  <img src="https://img.shields.io/badge/License-Proprietary-informational" alt="License"/>
</p>

---

## 📑 Sumário
- [Sobre o Projeto](#sobre-o-projeto)
- [Funcionalidades](#funcionalidades)
- [Tecnologias e Bibliotecas](#tecnologias-e-bibliotecas)
- [Padrões de Projeto](#padrões-de-projeto)
- [Setup e Execução](#setup-e-execução)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Autor](#-autor)

---

## 📝 Sobre o Projeto

O **AtomicListener** é uma aplicação <strong>Windows Forms</strong> em <strong>C#</strong> que implementa um <strong>hook global de teclado</strong>, permitindo capturar eventos de teclas pressionadas e liberadas em todo o sistema operacional. Ideal para demonstração de interceptação de teclas e manipulação de eventos de teclado em aplicações desktop.

---

## 🚀 Funcionalidades

✔️ Captura global de teclas (exemplo: <kbd>Ctrl</kbd> + <kbd>A</kbd>)  
✔️ Log de eventos de teclado em tempo real  
✔️ Manipulação da área de transferência (Clipboard)  
✔️ Interface simples baseada em um <code>ListBox</code> para exibição dos logs

---

## 🛠 Tecnologias e Bibliotecas

- <img src="https://img.shields.io/badge/.NET-4.0-blue?logo=dotnet" height="16"/> <strong>.NET Framework 4.0</strong>
- <img src="https://img.shields.io/badge/WinForms-UI-blueviolet?logo=windows" height="16"/> <strong>Windows Forms</strong> (`System.Windows.Forms`)
- <img src="https://img.shields.io/badge/WinAPI-Interop-yellow?logo=windows" height="16"/> <strong>Interop com WinAPI</strong> (`user32.dll`, `kernel32.dll` via `[DllImport]`)
- <strong>Namespaces:</strong>
  - <code>AtomicListener</code> (principal)
  - <code>Utilities</code> (hook global de teclado)

---

## 🏛 Padrões de Projeto

- <strong>Event-Driven</strong>: Uso extensivo de eventos (<code>KeyDown</code>, <code>KeyUp</code>) para desacoplamento entre captura e manipulação dos eventos de teclado.
- <strong>Resource Management</strong>: Implementação de <code>Dispose</code> e destrutores para liberar recursos nativos do hook.

---

## ⚙️ Setup e Execução

### Pré-requisitos
- 💻 Windows com .NET Framework 4.0 ou superior
- 🛠 Visual Studio 2010+ (ou compatível)

### Passos para rodar o projeto
1. Clone ou baixe este repositório.
2. Abra o arquivo <code>AtonicListener.sln</code> no Visual Studio.
3. Compile a solução (<kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>B</kbd>).
4. Execute (<kbd>F5</kbd>) ou rode o executável gerado em <code>bin/Debug/AtomicListener.exe</code>.

---

## 🗂 Estrutura do Projeto

```text
AtomicListenerKeyboard/
├── AtomicListener.csproj         # Projeto principal
├── AtonicListener.sln            # Solução Visual Studio
├── Form1.cs / .Designer.cs       # Formulário principal (UI)
├── globalKeyboardHook.cs         # Implementação do hook global de teclado
├── Program.cs                    # Ponto de entrada
├── Properties/                   # Recursos, AssemblyInfo, Settings
└── ...
```

---

> ⚠️ <strong>Observação:</strong> O projeto utiliza interoperação nativa com a API do Windows para captura global de teclado. Execute apenas em ambientes confiáveis.

---

## 👤 Autor
by **Rodolfo M. F. Abreu**
