   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:gestion_bibliotheque.Viewgestion_bibliotheque.View  5      +    %gestion_bibliotheque.View.Reservation   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:gestion_bibliotheque.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        � 	Resources  5
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
��20 0q�6   $��Center=�6&   ���#B0B9C6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��5      $�� ��6   �� 5      -   5        $��textBoxSearch��5        searchTextbox#��[ 6+   6R   .  (MahApps.Metro.IconPacks.PackIconMaterial  5          Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�6e   ���#B0B9C6$��Right=�6�   5!      �� 5$   
     	topButton#��[ 6   $��0 0 20 0q�64   ���#dcdcdc.��5%        $	 Cog=�6$   5&      �� 5(   
   #��[ 6   $��0 0 55 0q�64   .��5)        $
 Bell=�6$   5*      �� 5-   
   $��Reservations��6   $��1��6(   $��32(�65   $��SemiBold"�6C   $��0 20 0 0q�6Y   ���#121518$
��Left=�6�   �� 50   
   -   5          	addButton#��[ 50       � Cursor$
 Hand��6J   
���  ��.��51      ��  �� Orientation$ 
Horizontal=�6   .+�52        $ Export=�6(   $��Center=�66   $��0 1 8 0q�6Q   $��11��6b   $��11��6m   �� 53      $��Exporter��6   54      55      �� 58   
   $��1��6   $��3��6   ���#DAE2EA$��	0 -1 0 10q�6A   &   System.Windows.Controls.DataGrid  5B   
   -   5          Name$ ReservationsDataGrid��5E        DataGridRowStyle1	   RowStyle#	 �  5B        DataGridColumnHeaderStyle1
   ColumnHeaderStyle#
 �  5C        DataGridCellStyle1   	CellStyle# �  5D        DataGridStyle1#���  5F      $��0,10,0,7q�5H      $��5��5I         Columns 5J      4  .System.Windows.Controls.DataGridCheckBoxColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6)      CanUserResize$ False��64      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6J     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6W      HeaderTemplate 5L      �� 5M      .R�5N      �� #��[ 6'   5O      5Q      0  *System.Windows.Controls.DataGridTextColumn  5S      $ ReservationID��6%      
IsReadOnly$
 True��6<   $ False��6N   $
 Auto 6d      Binding 6q   �� *ReservationID+  5T      $ AdherntName��6%   $
 True��6:   $ False��6L   $
 Auto 6b    6o   �� *AdherntName+  5U      $ 
LivreTitre��6%   $
 True��69   $ False��6K   $
 Auto 6a    6n   �� *
LivreTitre+  5V      $ MontantAmende��6%   $
 True��6<   $ False��6N   $
 Auto 6d    6q   �� *MontantAmende+ �� StringFormat$ {0:C}��  5W      $ disponiblity��6%   $
 True��6]   $ * 6o    6<   �� *ProlongState+6o     5X      $ Category��6%   $
 True��6z   $ * 6�    67   �� *DateReservation+$ {0:dd-MM-yyyy}��6�   4  .System.Windows.Controls.DataGridTemplateColumn  5\      $
 True��6*   $
 Auto 6<      CellTemplate 5]      �� 5^      .R�5_      �� $ 
Horizontal=�6)   .+�5`   "   �� -   5        $��5 0 0 0q�5`   )    	 gridRemoveButton#��[	 6:   $
 Hand��6d   .��5a   &     $ DeleteOutline=�6<    
 gridButtonIcon#��[
 6Q   5b   #   5c      5d      5f      5h      �� 5m   
   $��6��6   $��Right=�6   ���#DEE4EC$��1q�6P    �� CornerRadius$ 5��6d    �� Padding$ 5q�6u   ���#ffffff$��
0 10 10 10q�6�   ._�5n      �� $ 
Horizontal=�6   .+�5o      ��   pagingButton#��[ 6   .��5p        $ ChevronLeft=�6,     pagingButtonIcon#��[ 6?   5q      �� 5r      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5t      #��[ 6   $��1��6?   �� 5u      #��[ 6   $��2��6?   ���#7950F2���#ffffff6`   �� 5v      #��[ 6   $��3��6?   �� 5x      $	��...��6   ���#6C7682$��Center=�6<   $
��10 0q�6W   $��15(�6e   �� 5z      #��[ 6   $��7��6?   �� 5{      #��[ 6   $��8��6?   �� 5|      #��[ 6   $��9��6?   �� 5~      $��1��6   ���#DEE4EC$	��3 7q�65   �� 5      #��[ 6   .��5�        $ ChevronRight=�6,   #��[ 6@   5�      5�      5�      5�      5�      