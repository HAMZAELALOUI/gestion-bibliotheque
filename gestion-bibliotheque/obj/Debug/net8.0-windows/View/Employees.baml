   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:gestion_bibliotheque.Viewgestion_bibliotheque.View  5      )    #gestion_bibliotheque.View.Employees   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:gestion_bibliotheque.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        � 	Resources  5
         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      � $��1��6   $��30 20 20 20q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $	��300��6   $
��Left=�6   .+�5      �� -   5         ��Name$ mainContent��5      �� 5      $
��20 0q�6   $��Center=�6&   ���#B0B9C6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��5   
   $�� ��6   �� 5!      -   5        $��textBoxSearch��5!        searchTextbox#��[ 6+   6R   .  (MahApps.Metro.IconPacks.PackIconMaterial  5#         Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�6e   ���#B0B9C6$��Right=�6�   5$      �� 5'   
     	topButton#��[ 6   $��0 0 20 0q�64   ���#dcdcdc.��5(        $	 Cog=�6$   5)      �� 5+   
   #��[ 6   $��0 0 55 0q�64   .��5,        $
 Bell=�6$   5-      �� 50   
   $��	Employees��6   $��1��6%   $��32(�62   $��SemiBold"�6@   $��0 20 0 0q�6V   ���#121518$
��Left=�6}   �� 53   
   -   5          	addButton#��[ 53       � Cursor$
 Hand��6K   .��54      ��  �� Orientation$ 
Horizontal=�6   .+�55        $
 Plus=�6(   $��Center=�64   $��0 1 8 0q�6O   $��11��6`   $��11��6k   �� 56      $��Ajouter Employees��6   57      58      �� 5;   
   $��1��6   $��3��6   ���#DAE2EA$��	0 -1 0 10q�6A   �� 5@   
   $��4��6W   $��18(�6d   $��SemiBold"�6r   ���#121518$
��Left=�6�   $��Center=�6�   ��6   �� *NumberOfEmployees+ �� StringFormat$ {0} Employees��6�   �� 5C   
   $��Filtrer par��6   $��4��6(   $��13(�65   $��SemiBold"�6C   $��	0 0 215 0q�6Y   ���#121518$��Right=�6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  5O   
   -   5        	  Name$	 employeeDataGrid��5R        DataGridRowStyle1
   RowStyle#
 �  5O        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5P        DataGridCellStyle1   	CellStyle# �  5Q        DataGridStyle1#���  5S      $��0,10,0,7q�5U      $��5��5V         Columns 5W      4  .System.Windows.Controls.DataGridCheckBoxColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6)      CanUserResize$ False��64      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6J     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6W      HeaderTemplate 5Y      �� 5Z      .R�5[      �� #��[ 6'   5\      5^      0  *System.Windows.Controls.DataGridTextColumn  5`      $ #��6%      
IsReadOnly$
 True��60   $ False��6B   $
 Auto 6X      Binding 6e   �� *	EmployeID+4  .System.Windows.Controls.DataGridTemplateColumn  5a      $ Member��6)   $
 True��69   $ * 6K      CellTemplate 5b      �� 5c      .R�5d      �� $ 
Horizontal=�6)   .+�5e   "   ��  �� CornerRadius$ 50��6)   $��0 0 10 0q�6;   ��6M   �� *	BgColor+._�5f   &   �� $��Center=�6E   $��Center=�6`   
���   �$��0 0 0 1q�6�   ��60   �� *Nom+6�   5g   #   �� 5i   "   $��Center=�6D   $��Center=�6_   
���   �$��0 0 0 1q�6�   ��6,   �� *Prenom+6�   5k      5l      5n        5p      $ Email Address��6%   $
 True��6V   $ * 6h    6=   �� *Role+6h     5q      $ Phone Number��6%   $
 True��6d   $ * 6v    6;   �� *AutresDetailsEmploye+6v     5s      $ 
Operations��6)   $
 True��6=   $
 Auto 6O    5t      �� 5u      .R�5v      �� $ 
Horizontal=�6)   .+�5w   "   �� -   5        $��5 0 0 0q�5w   )    	 gridEditButton#��[	 6:   $
 Hand��6b   .��5x   &     $ PencilBoxOutline=�6<    
 gridButtonIcon#��[
 6T   5y   #   �� 5z   "   -   5        $��5 0 0 0q�5z   )     gridRemoveButton#��[ 6:   $
 Hand��6d   .��5{   &     $ DeleteOutline=�6<   #��[
 6Q   5|   #   5}      5~      5�      5�      �� 5�   
   $��6��6   $��Right=�6   ���#DEE4EC$��1q�6P   $ 5��6d    �� Padding$ 5q�6u   ���#ffffff$��
0 10 10 10q�6�   ._�5�      �� $ 
Horizontal=�6   .+�5�      ��   pagingButton#��[ 6   .��5�        $ ChevronLeft=�6,     pagingButtonIcon#��[ 6?   5�      �� 5�      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5�      #��[ 6   $��1��6?   �� 5�      #��[ 6   $��2��6?   ���#7950F2���#ffffff6`   �� 5�      #��[ 6   $��3��6?   �� 5�      $	��...��6   ���#6C7682$��Center=�6<   $
��10 0q�6W   $��15(�6e   �� 5�      #��[ 6   $��7��6?   �� 5�      #��[ 6   $��8��6?   �� 5�      #��[ 6   $��9��6?   �� 5�      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5�      #��[ 6   .��5�        $ ChevronRight=�6,   #��[ 6@   5�      5�      5�      5�      5�      