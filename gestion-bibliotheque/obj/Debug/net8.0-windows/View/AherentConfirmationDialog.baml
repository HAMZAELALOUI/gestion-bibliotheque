   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:gestion_bibliotheque.Viewgestion_bibliotheque.View  5   	   9    3gestion_bibliotheque.View.AherentConfirmationDialog   5   	   1local'clr-namespace:gestion_bibliotheque.View  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
   
�������$��Regular"�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      $��	Open Sans)�5       � Title$ CMessageBox��5   	   $	��200��6   $	��400��6*    � WindowStyle$
 None=�66    � WindowStartupLocation$ CenterScreen=�6J   ��5
   	   Z� .��5      ��  �� CornerRadius$ 5��6   
������� �� Padding$ 5q�61   ._�5   
   �  � RowDefinitions 5      �� 5      $	��20* �6    �� 5      $	��60* �6    �� 5      $	��20* �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $	��20* �6'   �� 5      $	��80* �6'   .+�5      �� -   5        $��txtTitle��5      $��	Confirmer��6,   $��1��6=   
���iii�$��Center=�6b   $��20(�6}   $
��Bold"�6�   5       � 5!      $��1��6    5"      �� 5#      $	��30* �6'   �� 5$      $	��70* �6'   .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��msgLogo��5&   *   	   Kind$	 Error=�69   $��0��6F   $��Center=�6V   $��Center=�6q   $��50��6�   $��50��6�   
���  ��6�   �� 5'      -   5        $��
txtMessage��5'      $��1��6.   $;��5Êtes-vous sûr de vouloir supprimer cet adhérent ?��6>   
���iii�$��14(�6�   $��Center=�6�   $
��Left=�6�   $
��Wrap=�6�   5(      � 5)      $��2��6    5*      �� 5+      $	��20* �6'   �� 5,      $	��40* �6'   �� 5-      $	��40* �6'   �� 5.      $	��20* �6'   .+�50      �� -   5        $��btnOk��50      $��1��6&   $��	Supprimer��66   $��Center=�6K   $��Center=�6h   $��80��6�   ���	#FF698EF1
�������$��60��6�   
 � Cursor$

 Hand��6�   ��6�   Z� 6�   �� 53      -   5        $��	btnCancel��53      $��2��6*   $��Annuler��6:   $��60��6L   $��Center=�6Y   $��Center=�6v   $��80��6�   ���	#FFE60000
�������$

 Hand��6�   ��6�   Z� 6�   56      57      58      59      