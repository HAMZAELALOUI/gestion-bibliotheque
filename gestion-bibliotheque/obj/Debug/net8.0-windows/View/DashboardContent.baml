   M S B A M L   `   `   `  ����O  Kgestion-bibliotheque, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:gestion_bibliotheque.Viewgestion_bibliotheque.View  5      0    *gestion_bibliotheque.View.DashboardContent   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:gestion_bibliotheque.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .��5      � .+�5   
   � $��1��6   $��30 20 20 20q�6     � RowDefinitions  5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $
��auto �6    .+�5      �� -   5         ��Name$ dynamicContent��5      � 5      $��1��6   $��1��6#   ���	#FFCFCFCF.+�5      �� .��5      �   5      �� 5      $	��200 �6,   �� 5      $��* �6,   �� 5      $��* �6,    � ColumnDefinitions 5!      �� 5"      $��1* �6/   �� 5#      $��1* �6/   �� 5$      $��1* �6/   .+�5'      � $��0��6   .+�5(      �� $	��120��6(   $��20q�65   
������� �� RadiusY$ 10��6N    �� RadiusX$ 10��6[    J� Effect 5)   "   3  -System.Windows.Media.Effects.DropShadowEffect  5*   &      
BlurRadius$ 20Q�67      Color$ 	#FFDEDEDE��6G      RenderingBias$ Quality=�6Y   	   ShadowDepth$	 1Q�6q   5,      � 5-      $��25q�6#   $	��120��6/   .+�5.   "   � $��35��6'   $��50��62   ���	#FF41A43C$
��Left=�6U   $	��Top=�6p   $
��20 0q�6�    5/   &     50   *   $ 20Q�6;   $ 	#FFECECEC��6K   $ Quality=�6]   $	 1Q�6u   .+�52   &   .  (MahApps.Metro.IconPacks.PackIconMaterial  
   Kind$

 Book=�6<   $��Right=�6H   $��0,25,7,0q�6d   
�������$��20��6�   $��20��6�   53   #   �� 54   "   $��Livre��6,   $��Right=�69   $��Champagne & Limousines)�6U   $��5q�6}   $	��Top=�6�   
�������6�   �� 55   "    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   $	��Top=�6b   $��10 30q�6z   .+�56   &   �� -   5         ��Name$ livre��56   0   $��Champagne & Limousines)�6n   $��Center=�6�   
�������$��30(�6�   ��6@   �� *LivreViewModel.NumberOfLivre+6�   57   #   59      5;      � 5<      $��1��6   .+�5=      �� $	��120��6(   $��20q�65   
�������$ 10��6N   $ 10��6[    5>   "     5?   &   $ 20Q�67   $ 	#FFDEDEDE��6G   $ Quality=�6Y   $	 1Q�6q   5A      � 5B      $��25q�6#   $	��120��6/   .+�5C   "   � $��35��6'   $��50��62   ���	#FF41A43C$
��Left=�6U   $	��Top=�6p   $
��20 0q�6�    5D   &     5E   *   $ 20Q�6;   $ 	#FFECECEC��6K   $ Quality=�6]   $	 1Q�6u   .+�5G   &     $

 Plus=�6<   $��Right=�6H   $��0,25,7,0q�6d   
�������$��20��6�   $��20��6�   5H   #   �� 5I   "   $��Reservation��6,   $��Right=�6?   $��Champagne & Limousines)�6[   $��5q�6�   $	��Top=�6�   
�������6�   �� 5J   "   $ 
Horizontal=�6-   $��Right=�6F   $	��Top=�6b   $��10 30q�6z   .+�5K   &   �� -   5        $ reservation��5K   0   $��Champagne & Limousines)�6�   $��Center=�6�   
�������$��30(�6�   ��6F   �� *+)ReservationViewModel.NumberOfReservations+6�   5L   #   5N      5O      � 5P      $��2��6   .+�5Q      �� $	��120��6(   $��20q�65   
�������$ 10��6N   $ 10��6[    5R   "     5S   &   $ 20Q�67   $ 	#FFDEDEDE��6G   $ Quality=�6Y   $	 1Q�6q   5U      � 5V      $��25q�6#   $	��120��6/   .+�5W   "   � $��35��6'   $��50��62   ���	#FFCF1F1F$
��Left=�6U   $	��Top=�6p   $
��20 0q�6�    5X   &     5Y   *   $ 20Q�6;   $ 	#FFECECEC��6K   $ Quality=�6]   $	 1Q�6u   .+�5[   &     $
 FaceManProfile=�6<   $��Center=�6R   $��Bottom=�6o   $��5q�6�   
�������$��20��6�   $��20��6�   5\   #   �� 5]   "   $��Adherent��6,   $��Right=�6<   $��Champagne & Limousines)�6X   $��5q�6�   $	��Top=�6�   
�������6�   �� 5^   "   $ 
Horizontal=�6-   $��Right=�6F   $	��Top=�6b   $��10 30q�6z   .+�5_   &   �� -   5        $ adherent��5_   0   $��Champagne & Limousines)�6x   $��Center=�6�   
�������$��40(�6�   ��6C   �� *%#AherentsViewModel.NumberOfAdherents+6�   5`   #   5b      5c      5f      5g      5h      5i      5j      5k      