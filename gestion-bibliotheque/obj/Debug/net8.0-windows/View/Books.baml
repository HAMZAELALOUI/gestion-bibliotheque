   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:gestion_bibliotheque.Viewgestion_bibliotheque.View  5      %    gestion_bibliotheque.View.Books   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:gestion_bibliotheque.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        � 	Resources  5
         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      � $��1��6   $��30 20 20 20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $	��300��6   $
��Left=�6   .+�5      �� -   5         ��Name$ mainContent��5      �� 5      $
��20 0q�6   $��Center=�6&   ���#B0B9C6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��5      $�� ��6   �� 5      -   5        $��textBoxSearch��5        searchTextbox#��[ 6+   6R   .  (MahApps.Metro.IconPacks.PackIconMaterial  5          Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�6e   ���#B0B9C6$��Right=�6�   5!      �� 5$   
     	topButton#��[ 6   $��0 0 20 0q�64   ���#dcdcdc.��5%        $	 Cog=�6$   5&      �� 5(   
   #��[ 6   $��0 0 55 0q�64   .��5)        $
 Bell=�6$   5*      �� 5-   
   $��Livres��6   $��1��6"   $��32(�6/   $��SemiBold"�6=   $��0 20 0 0q�6S   ���#121518$
��Left=�6z   �� 50   
   -   5          	addButton#��[ 50       � Cursor$
 Hand��6F   .��51      ��  �� Orientation$ 
Horizontal=�6   .+�52        $
 Plus=�6(   $��Center=�64   $��0 1 8 0q�6O   $��11��6`   $��11��6k   �� 53      $��Ajouter Un Livre��6    J� RenderTransformOrigin$ -0.909,0.631&�64   54      55      �� 56   
   -   5        #��[ 56      $��
0,24,155,4q�6J   $ 0.5,0.5&�6^   $��1��6~   $	��117��6�   $
 Hand��6�   
���  ��z�57      V� 58      .~�59      �� 	 �� ScaleX$	 -1Q�6%   �� 5:      �� 5;      T� 5<      5=      .��5?      �� $ 
Horizontal=�6   .+�5@        $ Export=�6(   $��Center=�66   $��0 1 8 0q�6Q   $��12��6b   $��11��6m   $ 0.5,0.5&�6y   z�5A      V� 5B      .~�5C      �� $	 -1Q�6-   �� 5D      �� 5E      T� 5F      5G      5I      �� 5J      $��Exporter��6   $ 0.5,0.5&�6,   $��53��6L   z�5K      V� 5L      .~�5M      �� $	 -1Q�6-   �� 5N      �� 5O      T� 5P      5Q      5S      5T      5U      �� 5X   
   $��1��6   $��3��6   ���#DAE2EA$��	0 -1 0 10q�6A   �� 5]   
   $��4��6O   $��18(�6\   $��SemiBold"�6j   ���#121518$
��Left=�6�   $��Center=�6�   ��6   �� *NmberOfLivre+
 �� StringFormat$
 
{0} Livres��6�   &   System.Windows.Controls.DataGrid  5c   
   -   5          Name$ LivreDataGrid��5f        DataGridRowStyle1   RowStyle# �  5c        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5d        DataGridCellStyle1   	CellStyle# �  5e        DataGridStyle1#���  5g      $��0,10,0,7q�5i      $��5��5j         Columns 5k      4  .System.Windows.Controls.DataGridCheckBoxColumn  5l      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6)      CanUserResize$ False��64      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6J     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6W      HeaderTemplate 5m      �� 5n      .R�5o      �� #��[ 6'   5p      5r      0  *System.Windows.Controls.DataGridTextColumn  5t      $ LivreID��6%      
IsReadOnly$
 True��66   $ False��6H   $
 Auto 6^      Binding 6k   �� *	LivreID+  5u      $ Titre��6%   $
 True��64   $ False��6F   $
 Auto 6\    6i   �� *Titre+  5v      $ Auteur��6%   $
 True��65   $ False��6G   $
 Auto 6]    6j   �� *Auteur+  5w      $
 Prix��6%   $
 True��63   $ False��6E   $
 Auto 6[    6h   �� *Prix+$
 {0:C}��  5x      $ disponiblity��6%   $
 True��6e   $ * 6w    6<   �� *EstDisponibleDisplay+6w     5y      $ Category��6%   $
 True��6[   $ * 6m    67   �� *GetCategoryName+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5{      $
 True��6*   $
 Auto 6<      CellTemplate 5|      �� 5}      .R�5~      �� $ 
Horizontal=�6)   .+�5   "   �� -   5        $��5 0 0 0q�5   )    	 gridEditButton#��[	 6:   $
 Hand��6b   .��5�   &     $ PencilBoxOutline=�6<    
 gridButtonIcon#��[
 6T   5�   #   �� 5�   "   -   5        $��5 0 0 0q�5�   )     gridRemoveButton#��[ 6:   $
 Hand��6d   .��5�   &     $ DeleteOutline=�6<   #��[
 6Q   5�   #   5�      5�      5�      5�      �� 5�   
   $��6��6   $��Right=�6   ���#DEE4EC$��1q�6P    �� CornerRadius$ 5��6d    �� Padding$ 5q�6u   ���#ffffff$��
0 10 10 10q�6�   ._�5�      �� $ 
Horizontal=�6   .+�5�      ��   pagingButton#��[ 6   .��5�        $ ChevronLeft=�6,     pagingButtonIcon#��[ 6?   5�      �� 5�      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5�      #��[ 6   $��1��6?   �� 5�      #��[ 6   $��2��6?   ���#7950F2���#ffffff6`   �� 5�      #��[ 6   $��3��6?   �� 5�      $	��...��6   ���#6C7682$��Center=�6<   $
��10 0q�6W   $��15(�6e   �� 5�      -   5        #��[ 5�      $��7��6?   6K   �� 5�      #��[ 6   $��8��6?   �� 5�      #��[ 6   $��9��6?   �� 5�      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5�      #��[ 6   .��5�        $ ChevronRight=�6,   #��[ 6@   5�      5�      5�      5�      5�      