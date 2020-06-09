using ConceptMatrix.Models;
using ConceptMatrix.Utility;
using ConceptMatrix.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Media3D;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace ConceptMatrix.Views
{
    /// <summary>
    /// Interaction logic for CharacterDetailsView5.xaml
    /// </summary>
    public partial class PoseMatrixView3D : UserControl
    {
        public static PoseMatrixView3D PosingMatrix;
        public CharacterDetails CharacterDetails { get => (CharacterDetails)BaseViewModel.model; set => BaseViewModel.model = value; }
        private string GAS(params string[] args) => MemoryManager.GetAddressString(args);

        private MemoryManager Memory = MemoryManager.Instance;
        private readonly Mem m = MemoryManager.Instance.MemLib;

        public PoseMatrixView3D()
        {
            InitializeComponent();
            PosingMatrix = this;
            if (SaveSettings.Default.HasBackground == false) PoseBG.Opacity = 0;
        }
    }
}