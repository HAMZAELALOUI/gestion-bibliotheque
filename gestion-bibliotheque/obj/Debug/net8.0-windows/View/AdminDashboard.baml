   M S B A M L   `   `   `  ����  gestion-bibliotheque.    (gestion_bibliotheque.View.AdminDashboard   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   $	��720��5   	   $
��1080��6     � WindowStartupLocation$  CenterScreen=�6#    � AllowsTransparency$
 True��6H   
������  � WindowStyle$
 None=�5   "    � 	Resources 5         	BoolToVis��%   &	        �� 5	   
   6'   5
      .��5      �� -   5         �� CornerRadius$ 30��5      ���#EFF2F7._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      �� -   5          	topButton#��[ 5      $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5      �� 5       $��1��6   ���#07BF96$ 	0 30 0 30��6;   ._�5!      ]� .+�5#      �� $��80��6!   $��80��6,    �� Padding$ 3q�68   
�������$	 100��6W   $	��Top=�6j   $
��Left=�6   $��
20 -30 0 0q�6�   ._�5$      A� ��5%   "   �� 5&   &   	 �� ImageSource$	 /Images/profile.jpg��61   5(      5)      �� 5,      $��Library ��6$   
�������$��22(�6G   $��SemiBold"�6U   $	��Top=�6k   $��	5 25 0 10q�6�   
 �� TextAlignment$
 Center=�6�   �� 5-      $��marrakech, maroc��6$   ���#D0BFFF$��14(�6Q   $��SemiBold"�6_   $	��Top=�6u   $
 Center=�6�   �� 50      $��25q�6$   ���#7E5FDC$	��Top=�6E   $	��0.8��6Z   �� 53      $	��Top=�6%   .+�54      �� -   5          
menuButton#��[ 54   %    � Cursor$
 Hand��6I   .��55   "   ��  �� Orientation$ 
Horizontal=�6-   .+�56   &     $ HomeVariant=�6<     menuButtonIcon#��[ 6O   �� 57   &   $��	Dashboard��60   58   #   59      �� 5;      -   5        #��[ 5;   %   $
 Hand��6c   .��5<   "   �� $ 
Horizontal=�6-   .+�5=   &     $ CalendarClock=�6<   #��[ 6Q   �� 5>   &   $��Reservation��60   5?   #   5@      �� 5B      -   5        #��[ 5B   %   $
 Hand��6b   .��5C   "   �� $ 
Horizontal=�6-   .+�5D   &     $ AccountMultipleOutline=�6<   #��[ 6Z   �� 5E   &   $��	Adherents��60   5F   #   5G      �� 5I      -   5        #��[ 5I   %   $
 Hand��6\   .��5J   "   �� $ 
Horizontal=�6-   .+�5K   &     $ 	Bookshelf=�6<   #��[ 6M   �� 5L   &   $��Livres��60   5M   #   5N      �� 5P      -   5        #��[ 5P   %   $
 Hand��6`   .��5Q   "   �� $ 
Horizontal=�6-   .+�5R   &     $ Account=�6<   #��[ 6K   �� 5S   &   $��	Employees��60   5T   #   5U      5W      �� 5Y      -   5        #��[ 5Y   !   $��Bottom=�6E   $��Bottom=�6`   $��
15 0 15 20q�6x   $
 Hand��6�   .��5Z      �� $ 
Horizontal=�6)   .+�5[   "     $ Logout=�68   #��[ 6F   �� 5\   "   $��Logout��6,   5]      5^      5`      5a      5c      � 5i      $��1��6   $��30 20 20 20q�6#    5j      �� 5k      $
��auto �6$   �� 5l      $
��auto �6$   �� 5m      $
��auto �6$   �� 5n      $
��auto �6$   �� 5o      $
��auto �6$   �� 5p      $��* �6$   �� 5q      $
��auto �6$   .+�5u      �� -	   5         ��Name$ dynamicContent��5u   !   5w      5y      5z      5{      