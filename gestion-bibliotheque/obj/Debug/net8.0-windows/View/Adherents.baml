   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:gestion_bibliotheque.Viewgestion_bibliotheque.View  5      )    #gestion_bibliotheque.View.Adherents   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:gestion_bibliotheque.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        � 	Resources  5
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
��20 0q�6   $��Center=�6&   ���#B0B9C6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��5      $�� ��6!   �� 5!      -   5        $��textBoxSearch��5!        searchTextbox#��[ 6+   6R   .  (MahApps.Metro.IconPacks.PackIconMaterial  5#         Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�6e   ���#B0B9C6$��Right=�6�   5$      �� 5(   
     	topButton#��[ 6   $��0 0 20 0q�64   ���#dcdcdc.��5)        $	 Cog=�6$   5*      �� 5,   
   #��[ 6   $��0 0 55 0q�64   .��5-        $
 Bell=�6$   5.      �� 51   
   $�� ��6   $��1��6   $��32(�6)   $��SemiBold"�67   $��0 20 0 0q�6M   ���#121518$
��Left=�6t   �� 54   
   -   5          	addButton#��[ 54       � Cursor$
 Hand��6J   .��55      ��  �� Orientation$ 
Horizontal=�6   .+�56        $
 Plus=�6(   $��Center=�64   $��0 1 8 0q�6O   $��11��6`   $��11��6k   �� 57      $��Ajouter Aherents��6   58      59      �� 5<   
   $��1��6   $��3��6   ���#DAE2EA$��	0 -1 0 10q�6A   �� 5A   
   $��4��6W   $��18(�6d   $��SemiBold"�6r   ���#121518$
��Left=�6�   $��Center=�6�   ��6   �� *NumberOfAdherents+ �� StringFormat$ {0} Adherents��6�   &   System.Windows.Controls.DataGrid  5I   
   -   5        	  Name$	 adherentsDataGrid��5L        DataGridRowStyle1
   RowStyle#
 �  5I        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5J        DataGridCellStyle1   	CellStyle# �  5K        DataGridStyle1#���  5M      $��0,10,0,7q�5O      $��5��5P         Columns 5Q      4  .System.Windows.Controls.DataGridCheckBoxColumn  5R      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6)      CanUserResize$ False��64      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6J     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6W      HeaderTemplate 5S      �� 5T      .R�5U      �� #��[ 6'   5V      5X      0  *System.Windows.Controls.DataGridTextColumn  5Z      $ #��6%      
IsReadOnly$
 True��60   $ False��6B   $
 Auto 6X      Binding 6e   �� *
AdherentID+4  .System.Windows.Controls.DataGridTemplateColumn  5[      $ Member��6)   $
 True��69   $ * 6K      CellTemplate 5\      �� 5]      .R�5^      �� $ 
Horizontal=�6)   .+�5_   "   ��  �� CornerRadius$ 50��6)   $��0 0 10 0q�6;   ��6M   �� *	BgColor+._�5`   &   �� $��Center=�6E   $��Center=�6`   
���   �$��0 0 0 1q�6�   ��60   �� *Nom+6�   5a   #   �� 5c   !   $��Center=�6C   $��Center=�6^   
���   �$��0 0 0 1q�6�   ��6+   �� *Prenom+6�   5e      5f      5h        5j      $ Email Address��6%   $
 True��6V   $ * 6h    6<   �� *Email+6h     5k      $ Phone Number��6%   $
 True��6_   $ * 6q    6;   �� *NumeroTelephone+6q     5m      $ 
Operations��6)   $
 True��6=   $
 Auto 6O    5n      �� 5o      .R�5p      �� $ 
Horizontal=�6)   .+�5r   "   �� -   5        $��5 0 0 0q�5r   )    	 gridRemoveButton#��[	 6:   $
 Hand��6d   .��5s   &     $ DeleteOutline=�6<    
 gridButtonIcon#��[
 6Q   5t   #   5u      5v      5x      5z      �� 5}   
   $��6��6   $��Right=�6   ���#DEE4EC$��1q�6P   $ 5��6d    �� Padding$ 5q�6u   ���#ffffff$��
0 10 10 10q�6�   ._�5~      �� $ 
Horizontal=�6   .+�5      ��   pagingButton#��[ 6   .��5�        $ ChevronLeft=�6,     pagingButtonIcon#��[ 6?   5�      �� 5�      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5�      #��[ 6   $��1��6?   �� 5�      #��[ 6   $��2��6?   ���#7950F2���#ffffff6`   �� 5�      #��[ 6   $��3��6?   �� 5�      $	��...��6   ���#6C7682$��Center=�6<   $
��10 0q�6W   $��15(�6e   �� 5�      #��[ 6   $��7��6?   �� 5�      #��[ 6   $��8��6?   �� 5�      #��[ 6   $��9��6?   �� 5�      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5�      #��[ 6   .��5�        $ ChevronRight=�6,   #��[ 6@   5�      5�      5�      5�      5�      