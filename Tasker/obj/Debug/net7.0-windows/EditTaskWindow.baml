   M S B A M L   `   `   `  ����A  =Tasker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TaskerTasker  5   	       Tasker.EditTaskWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tasker     5   	   -   5          � Title$  Tasker��5   	   $	��326��6   $	��535��6%    � 
ResizeMode$ NoResize=�61    � WindowStyle$
 None=�6G    � 	Resources 5	         CombinedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value N� EnterActions �� TargetProperty	 �� To g� Duration N� ExitActions��%  &	        �� 5
   
   " ��6,   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5      #��z��5      $ 3��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver$
 True��6=    5   "   �� 5   &   .��5   *   �� .��5   .   �� $1 +(Border.Background).(SolidColorBrush.Color)�6=    #EAEAEA6�   $ 0:0:0.2D�6�   �� 5   .   $1 +(Button.Foreground).(SolidColorBrush.Color)�6=   	 Black6�   $ 0:0:0.2D�6�   5   +   5   '    5   "   �� 5   &   .��5    *   �� .��5!   .   �� $1 +(Border.Background).(SolidColorBrush.Color)�6=    	#FF0C0C0C6�   $ 0:0:0.2D�6�   �� 5"   .   $1 +(Button.Foreground).(SolidColorBrush.Color)�6=   	 White6�   $ 0:0:0.2D�6�   5#   +   5$   '   5&      5(      5*      �� 5+       � �� �	#FF0C0C0C6+   �� 5,       � ��
 �����6+   �� 5-       � ��$ 0q�60   �� 5.       � ��$ 10,50q�6(   5/      50      .��51      �  � RowDefinitions 52   
   �� 53      $
��194* �6   �� 54      $
��133* �6   .+�56   
   �� -   5         ��Name$ EditTaskLabel��56      $��Edit a task��6'   $
��Left=�6=   $��	10,-4,0,0q�6X   $	��Top=�6k   $��Bahnschrift Condensed)�6�   $��48(�6�   �� 57   
   -   5        $ TitleTaskLabel��57      $��Title��6(   $
��Left=�68   $��	10,44,0,0q�6S   $	��Top=�6f   $��Bahnschrift Condensed)�6~   $��36(�6�   �� 58   
   -   5        $ DescriptionTaskLabel��58      $��Description��6.   $
��Left=�6D   $��	10,99,0,0q�6_   $	��Top=�6r    J� RenderTransformOrigin$ 0.413,0.398&�6�   $��Bahnschrift Condensed)�6�   $��28(�6�   �� 59   
   -   5         ��Name$ TitleTaskTextBox��59      $
��Left=�6,   $��	13,86,0,0q�6G    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��512��6�   ���	#FFC3C3C3���	#FFF7F7F76�   �� 5:   
   -   5        $ DescriptionTextBox��5:      $
��Left=�6.   $��
13,136,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��512��6�   $	��124��6�   ���	#FFF7F7F7���	#FFC3C3C3$��2��6�   �� 5;   
   -   5         ��Name$ CancelButton��5;      #��[  6'   $��Cancel��6T   $
��Left=�6e   $��
315,76,0,0q�6�   $	��Top=�6�   $��40��6�   $	��101��6�   $��0,0,0,0q�6�   $��22(�6�   $��Bahnschrift SemiBold)�6  ���	#FF131313
�������$��1��6g  ��6�   Z� 6g  �� 5<   
   -   5        $ 
EditButton��5<      #��[  6%   $
��Edit��6R   $
��Left=�6a   $��
424,76,0,0q�6|   $	��Top=�6�   $��40��6�   $	��101��6�   $��0,0,0,0q�6�   $��25(�6�   $��Bahnschrift SemiBold)�6�   ���	#FF131313
�������$��1��6d  ��6�   Z� 6d  �� 5=   
   -	   5        $ 	DateLabel��5=      $��Date:��6#   $
��Left=�63   $��	10,60,0,0q�6N   $	��Top=�6a   $��Bahnschrift Condensed)�6y   $��30(�6�   $��1��6�   �� 5>   
   -
   5        $ 	TimeLabel��5>      $��Time:��6#   $
��Left=�63   $��	10,90,0,0q�6O   $	��Top=�6b   $��Bahnschrift Condensed)�6z   $��30(�6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5?   
   -   5          Name$ DatePickerTaskDate��5?      $
��Left=�61   $��	69,71,0,0q�6L   $	��Top=�6_   $	��122��6w   
����������	#FFA4A5AB$��24��6�   
���   �$��1��6  �� 5@   
   -   5        $ TimeTextBox��5@      $
��Left=�6g   $��
69,102,0,0q�6�   $
 Wrap=�6�   $��00:00��6�   $	��Top=�6�   $	��122��6�   $��20��6�   ���	#FFF7F7F7$��1��6�   5A      5B      