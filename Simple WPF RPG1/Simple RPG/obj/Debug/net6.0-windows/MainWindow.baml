   M S B A M L   `   `   `  ����E  ASimple RPG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Simple_RPG
Simple_RPG  5   	       Simple_RPG.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Simple_RPG     5   	     � Title$  
Simple RPG��5   	   $
��1080��6   $
��1920��6*   $��20(�67   $��Vivaldi)�6E   $
��Bold"�6Z    � 	Resources 5	         BooleanToVisibility��%   &	        �� 5
   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��3* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   $	��300��6*   �� 5      $��4* �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $
��Menu��6A   
�������6P   � 5   
   $��1��6   $��0��6   
������ 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6     5%      �� 5&      $
��Auto �6#   �� 5'      $
��Auto �6#   .+�5)      �� $��0��6   $��0��6!   $��Name:��61   �� 5*      $��0��6   $��1��6!   ��61   �� *CurrentPlayer.Name+�� 5+      $��1��6   $��0��6!   $��Level:��61   �� 5,      $��1��6   $��1��6!   ��61   �� *CurrentPlayer.Level+�� 5-      $��2��6   $��0��6!   $��Class:��61   �� 5.      $��2��6   $��1��6!   ��61   �� *CurrentPlayer.CharClass+�� 5/      $��3��6   $��0��6!   $��Hit Points:��61   �� 50      $��3��6   $��1��6!   ��61   �� *CurrentPlayer.HitPoints+�� 51      $��4��6   $��0��6!   $��Experience:��61   �� 52      $��4��6   $��1��6!   ��61   �� * CurrentPlayer.ExperiencePoints+�� 53      $��5��6   $��0��6!   $
��Gold��61   �� 54      $��5��6   $��1��6!   ��61   �� *CurrentPlayer.Gold+�� 55      -   5        $��7��55      $��0��6"   $��Debug Button��62   6I   56      � 57   
   $��1��6   $��1��6   
������� 58      �� 59      $��* �6    �� 5:      $��* �6     5<      �� 5=      $��3* �6#   �� 5>      $��2* �6#   .+�5@      �� $��0��6   $��1��6"   
���   �$��1q�6F   ._�5A      �  5B      �� 5C      $
��Auto �6(   �� 5D      $��* �6(   �� 5E      $
��Auto �6(   .+�5G      �� $��0��6   $��Center=�6)   ��6F   �� *CurrentLocation.Name+�� 5H      $��1��6   $��Center=�6)   $��Center=�6F   $	��300��6a   ��6n   �� *CurrentLocation.ImageFile+6�   �� 5I      $��2��6   $��Center=�6)   ��6F   �� *CurrentLocation.Description+5J      5K      5L      �� 5M   
   $��2��6   $��0��6   $��Inventory/Quests��6-   
�������6H   � 5O   
   $��2��6   $��1��6   
������� 5P      �� 5Q      $��* �6     5S      �� 5T      $��3* �6#   �� 5U      $��2* �6#   .+�5W      � $��0��6   $��1��6     5X      �� 5Y      $��* �6$   �� 5Z      $��* �6$   �� 5[      $��* �6$    5]      �� 5^      $��* �6'   �� 5_      $��* �6'   �� 5`      $��* �6'   .+�5b      �� -   5        $��0��5b      $��1��6&   $��North��6�   y�6S   �� *HasLocationNorth+ �� 	Converter# [  6�   �� 5c      -   5        $��1��5c      $��0��6&   $
��West��6�   y�6S   �� *HasLocationWest+# [  6�   �� 5d      -   5        $��1��5d      $��2��6&   $
��East��6�   y�6S   �� *HasLocationEast+# [  6�   �� 5e      -   5        $��2��5e      $��1��6&   $��South��6�   y�6S   �� *HasLocationSouth+# [  6�   5f      5g      5i      5j      