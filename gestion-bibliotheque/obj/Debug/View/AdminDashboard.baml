   M S B A M L   `   `   `  ����  gestion-bibliotheque.    (gestion_bibliotheque.View.AdminDashboard   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   $	��720��5   	   $
��1080��6     � WindowStartupLocation$  CenterScreen=�6#    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   "    � 	Resources 5         	BoolToVis��%   &	        �� 5	   
   6'   5
      .��5      �� -   5         �� CornerRadius$ 30��5      ���#EFF2F7._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      �� -   5          	topButton#��[ 5      $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5      �� 5      $��1��6   ���#07BF96$ 	0 30 0 30��6;   ._�5       ]� .+�5"      �� $��80��6!   $��80��6,    �� Padding$ 3q�68   
�������$	 100��6W   $	��Top=�6j   $
��Left=�6   $��
20 -30 0 0q�6�   ._�5#      A� ��5$   "   �� 5%   &   	 �� ImageSource$	 /Images/profile.jpg��61   5'      5(      �� 5+      $��Library ��6$   
�������$��22(�6G   $��SemiBold"�6U   $	��Top=�6k   $��	5 25 0 10q�6�   
 �� TextAlignment$
 Center=�6�   �� 5,      $��hamza, France��6$   ���#D0BFFF$��14(�6N   $��SemiBold"�6\   $	��Top=�6r   $
 Center=�6�   �� 5/      $��25q�6$   ���#7E5FDC$	��Top=�6E   $	��0.8��6Z   �� 52      $	��Top=�6%   .+�53      ��   
menuButton#��[ 6%    � Cursor$
 Hand��6I   .��54   "   ��  �� Orientation$ 
Horizontal=�6-   .+�55   &     $ HomeVariant=�6<     menuButtonIcon#��[ 6O   �� 56   &   $��	Dashboard��60   57   #   58      �� 5:      -   5        #��[ 5:   %   $
 Hand��6c   .��5;   "   �� $ 
Horizontal=�6-   .+�5<   &     $ CalendarClock=�6<   #��[ 6Q   �� 5=   &   $��Reservation��60   5>   #   5?      �� 5A      -   5        #��[ 5A   %   $
 Hand��6b   .��5B   "   �� $ 
Horizontal=�6-   .+�5C   &     $ AccountMultipleOutline=�6<   #��[ 6Z   �� 5D   &   $��	Adherents��60   5E   #   5F      �� 5H      -   5        #��[ 5H   %   $
 Hand��6\   .��5I   "   �� $ 
Horizontal=�6-   .+�5J   &     $ 	Bookshelf=�6<   #��[ 6M   �� 5K   &   $��Livres��60   5L   #   5M      �� 5O      -   5        #��[ 5O   %   $
 Hand��6`   .��5P   "   �� $ 
Horizontal=�6-   .+�5Q   &     $ Account=�6<   #��[ 6K   �� 5R   &   $��	Employees��60   5S   #   5T      5V      �� 5X      #��[ 6!   $��Bottom=�6E   $��Bottom=�6`   $��
15 0 15 20q�6x   $
 Hand��6�   .��5Y      �� $ 
Horizontal=�6)   .+�5Z   "     $ Logout=�68   #��[ 6F   �� 5[   "   $��Logout��6,   5\      5]      5_      5`      5b      � 5h      $��1��6   $��30 20 20 20q�6#    5i      �� 5j      $
��auto �6$   �� 5k      $
��auto �6$   �� 5l      $
��auto �6$   �� 5m      $
��auto �6$   �� 5n      $
��auto �6$   �� 5o      $��* �6$   �� 5p      $
��auto �6$   .+�5t      �� -   5         ��Name$ dynamicContent��5t   !   5u      5w      5x      5y      