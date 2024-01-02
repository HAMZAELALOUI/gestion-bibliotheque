using gestion_bibliotheque.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gestion_bibliotheque.View.InputForm.UserControls
{
    /// <summary>
    /// Interaction logic for MyComboBox.xaml
    /// </summary>
    public partial class MyComboBox : UserControl
    {

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MyComboBox));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public MyComboBox()
        {
            InitializeComponent();
            CategoriesHelperDB dbHelper = new CategoriesHelperDB();
            myComboBox.ItemsSource = dbHelper.GetCategories();
            myComboBox.DisplayMember = "Name";
        }
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(MyComboBox));

        public string DisplayMember
        {
            get { return (string)GetValue(DisplayMemberProperty); }
            set { SetValue(DisplayMemberProperty, value); }
        }


        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register("Hint", typeof(string), typeof(MyComboBox));

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
        public static readonly DependencyProperty SelectedCategoryProperty =
        DependencyProperty.Register("SelectedCategory", typeof(Categorie), typeof(MyComboBox));

        public Categorie SelectedCategory
        {
            get { return (Categorie)GetValue(SelectedCategoryProperty); }
            set { SetValue(SelectedCategoryProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemIdProperty =
     DependencyProperty.Register("SelectedItemId", typeof(int), typeof(MyComboBox));

        public int SelectedItemId
        {
            get { return (int)GetValue(SelectedItemIdProperty); }
            set { SetValue(SelectedItemIdProperty, value); }
        }

        // Expose the selected category ID directly
        public int SelectedCategoryID => SelectedCategory?.GetCategorieID ?? 0;

        private void OnComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle selection change to update SelectedItemId and SelectedCategory
            if (comboBox.SelectedItem is Categorie selectedCategory)
            {
                SelectedItemId = selectedCategory.GetCategorieID;
                SelectedCategory = selectedCategory;  // Update SelectedCategory
            }
            else
            {
                SelectedItemId = 0;
                SelectedCategory = null;  // Set SelectedCategory to null if the selected item is not of type Categorie
            }
        }

        public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register("Caption", typeof(string), typeof(MyComboBox));
        public static readonly DependencyProperty DisplayMemberProperty =
            DependencyProperty.Register("DisplayMember", typeof(string), typeof(MyComboBox));


        //ok test
        public static readonly RoutedEvent CustomSelectionChangedEvent = EventManager.RegisterRoutedEvent(
        "CustomSelectionChanged",
        RoutingStrategy.Bubble,
        typeof(RoutedEventHandler),
        typeof(MyComboBox)
    );

        public event RoutedEventHandler CustomSelectionChanged
        {
            add { AddHandler(CustomSelectionChangedEvent, value); }
            remove { RemoveHandler(CustomSelectionChangedEvent, value); }
        }

        // ... your existing code ...

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            // Handle selection change to update SelectedItemId and SelectedCategory
            if (comboBox.SelectedItem != null)
            {
                // Raise the custom event when the selection changes
                RoutedEventArgs args = new RoutedEventArgs(CustomSelectionChangedEvent);
                RaiseEvent(args);
            }


        }

       public int GetSelectedAdherentId()
        {
            if (comboBox.SelectedItem != null)
            {
                if (comboBox.SelectedItem is Categorie selectedCategory)
                {
                    return selectedCategory.CategorieID;
                }
            }
            return 0; // Return 0 or another value to indicate no selection
        }

      
    }
}