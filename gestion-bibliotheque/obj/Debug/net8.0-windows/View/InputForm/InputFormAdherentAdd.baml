   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:gestion_bibliotheque.View.InputForm.UserControls0gestion_bibliotheque.View.InputForm.UserControls  5   	   >    8gestion_bibliotheque.View.InputForm.InputFormAdherentAdd   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Muc>clr-namespace:gestion_bibliotheque.View.InputForm.UserControls     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   $
��1150��5   	   $	��500��6   $	��750��6#   $	��790��62     � WindowStyle$
  None=�6B    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��6.   
������ '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 5q�6)   .��5      �� -   5         �� CornerRadius$ 5��5      ���#ffffff._�5   
   �  � RowDefinitions 5      �� 5      $��45 �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��400 �6#   .+�5      �� $��Library��6   $
��Left=�6'   $��Center=�6B   $��55 0 0 2q�6]   $��16(�6o   $��SemiBold"�6}   ���#4880FF6�   .  (MahApps.Metro.IconPacks.PackIconMaterial  5      	   Kind$
	 Book=�6$   $
��Left=�60   $��Center=�6K   $��33 0 0 4q�6f   $��14��6x   $��14��6�   ���#FF9D006�     5      $
	 Book=�6$   $
��Left=�60   $��Center=�6K   $��30 4 0 0q�6f   $��14��6x   $��14��6�   ���#4880FF6�   �� 5      
 �� Orientation$
 
Horizontal=�6   $��1��62   $��Right=�6B   $��0 0 15 0q�6^   .+�5       �� $��Pour Ajouter un Adherent��6   ���#374655$��Center=�6Q   $��14(�6l   $��0 0 65 0q�6z   5'      �� 5*      $��1��6   $��1��6"   ���#07BF96$ 0 0 5 0��6G   ._�5+      �� $��	60 0 10 0q�6   .+�5.      �� $��85��6   $��85��6)   
������ $��15 40 20 20q�6N   50      57      58      �� 5;      $��1��6   ���#F2F5F8$ 0 0 0 5��67   ._�5<      � $��Center=�6   $��
70 0 -60 0q�62   .+�5>      �� $ 7 0 0 0��6   ���#F7F8FB$��50��6I   $��40 -30 60 0q�6U   $	��Top=�6j   �� 5?      $ 7 0 0 0��6   ���#FDFDFD$��50��6I   $��20 -15 60 0q�6U   $	��Top=�6j   �� 5B      $ 7��6   ���#ffffff J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         	Direction$
 -130Q�6/      
BlurRadius$ 30Q�6@      ShadowDepth$ 5Q�6P      Opacity$	 0.1Q�6`   ._�5G      � $
��20 0q�6    5H      �� 5I   "   $
��auto �60   �� 5J   "   $
��auto �60   �� 5K   "   $��* �60   �� 5L   "   $��* �60   �� 5M   "   $��* �60   �� 5N   "   $��* �60   �� 5O   "   $
��auto �60    5R      �� 5S   "   $��* �63   �� 5T   "   $��* �63   .+�5X      �� $
 
Horizontal=�6)   $��	20 20 0 0q�6B   .+�5Y   "   �� $ 50��6)   $	��1.5q�6;   ���#EFEFEF5[   #   �� 5]   "   $��Ajouter Adherent��6,   ���#374655$��18(�6Y   $��15 0 0 0q�6g   $��Center=�6y   5^      �� 5a      $
 
Horizontal=�6)   $��1��6B   $��Right=�6R   $��	0 20 20 0q�6n   .+�5b   "   �� $��30��6)   $��30��64   $ 50��6@   $��3q�6R   $
}�True��6f   ��5c   &   �� 5d   *   .��5e   .   �  � Color$ #4880FF��6;    � Offset$ 0Q�6K   � 5f   .   $ #EFEFEF��6;   $	 0.4Q�6K   5g   +   5i   #   5l      �� 5n      $��1��6(   $��2��65   $	��0.7��6I   $��-20 20 -20 20q�6V   ���#E1E6EB6m   @   :gestion_bibliotheque.View.InputForm.UserControls.MyTextBox  5r      -   5          Name$ txtNom��5r   +   $��0��6Q   $��2��6a      Caption$	 Nom��6n      Hint$ Entrer Le nom��6|      Text 6;   �� *Nom+6|     5s      -   5        $ txtEmail��5s   +   $��0��6T   $��3��6d   $ Email��6q   $ Entrer l'email��6�    6=   �� *Email+6�     5t      -   5        $ txtTelephone��5t   +   $��0��6\   $��4��6l   $ 	Telephone��6y   $ Numerau de Telephone��6�    6A   �� *	Telephone+6�     5u      -   5        $ 
txtAddress��5u   +   $��0��6X   $��5��6h   $ Address ��6u   $ entrer l'adress��6�    6?   �� *	Address+6�     5v      -   5        $ 	txtPrenom��5v   +   $��1��6W   $��2��6g   $ Prenom��6t   $ Entrer le prenom��6�    6>   �� *Prenom+6�     5w      -   5        $ txtMotDePasse��5w   +   $��1��6d   $��3��6t   $ Mot de Pass��6�   $ Mot de Pass��6�    6B   �� *PrenomMotDePasse+6�     5x      -   5        $ txtDescription��5x   +   $��1��6e   $��3��6u   $ Description��6�   $ Description��6�   $��0,77,0,0q�6�   $��3��6�    6C   �� *PrenomMotDePasse+6�   �� 5      $��6��6%   $��2��62   $��80��6F   ���#f6f6f6$ 	0 0 10 10��6g   $��-20 40 -20 0q�6�   �� 5�      -	   5        $��1��5�   %   $��6��65   $��Ajouter��6B   $��Right=�6T   $��	0 40 20 0q�6p      
mainButton#��[  6�    � Cursor$
 Hand��6�    5�   "     5�   &   $
 -120Q�67   $ 10Q�6H   $	 0.3Q�6X   $ 5Q�6f      Color$ #4880FF��6v   5�      �� 5�      -
   5        $��6��5�   %   $��Retour��62   $
��Left=�6C   $��	20 40 0 0q�6^     secondaryButton#��[ 6q   $	��150��6�   $
 Hand��6�   6�   5�      5�      5�      5�      5�      5�      5�      