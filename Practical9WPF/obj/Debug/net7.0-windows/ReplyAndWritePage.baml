   M S B A M L   `   `   `  ����H  DPractical9WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Practical9WPFPractical9WPF  5      %    Practical9WPF.ReplyAndWritePage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:Practical9WPF  5        N� Title$  ReplyAndWritePage��5	      .��5
      � ���#696969 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   � $��0��6   ���#D3D3D3 � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      �� 5      $	��100 �6#   .+�5      �� -   5        $
��toTB��5   5   $��0��6   $��0��6(   $��
Кому: ��6A   $��18(�6O    �� TextAlignment$ Center=�6]   $��5q�6u   �� 5      $��1��6   $��18(�6&   $��5q�64   �� 5      $��2��6   $��20(�6'   $��5q�65   .@�5      �� $
��Mail��6   
 � Tag$ smtp.mail.ru��6.   �� 5      $��Yandex��6   $ smtp.yandex.ru��60   �� 5      $��Rambler��6   $ smtp.rambler.ru��61   5      5      � 5    
   $��1��6   ���#D3D3D3 5!      �� 5"      $	��100 �6#   �� 5#      .+�5%      �� -   5        $��	subjectTB��5%      $��
Тема: ��6)   $��18(�67   $ Center=�6E   $��5q�6]   �� 5&      $��1��6   $��5q�6&   5'      c� 5(   
   $��2��6   .@�5)      �� $��ApplicationCommands.Cut��6   ��67   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 
ContentCut=��� 5*      $��ApplicationCommands.Copy��6   ��68     $ ContentCopy=��� 5+      $��ApplicationCommands.Paste��6   ��69     $ ContentPaste=��� 5,      �� 5-      $��ApplicationCommands.Undo��6   ��68     $
 Undo=��� 5.      $��ApplicationCommands.Redo��6   ��68     $
 Redo=��� 5/      �� 50      $ ��EditingCommands.ToggleBold��6   ��6:     $ 
FormatBold=��� 51      $"��EditingCommands.ToggleItalic��6   ��6<     $ FormatItalic=��� 52      $%��EditingCommands.ToggleUnderline��6   ��6?     $ FormatUnderline=��� 53      �� 54      $&�� EditingCommands.IncreaseFontSize��6   $��15(�6@   ��55      �� 56      $��Source/Up.png��6   $��20��63   58      �� 59      $&�� EditingCommands.DecreaseFontSize��6   $��15(�6@   ��5:      �� 5;      $��Source/Down.png��6   $��20��65   5=      �� 5>      �� 5?      $��EditingCommands.AlignLeft��6   ��69     $ FormatAlignLeft=��� 5@      $!��EditingCommands.AlignCenter��6   ��6;     $ FormatAlignCenter=��� 5A      $ ��EditingCommands.AlignRight��6   ��6:     $ FormatAlignRight=��� 5B      $"��EditingCommands.AlignJustify��6   ��6<     $ FormatAlignJustify=��� 5C      �� 5D      $)��#EditingCommands.IncreaseIndentation��6   ��6C     $ FormatIndentIncrease=��� 5E      $)��#EditingCommands.DecreaseIndentation��6   ��6C     $ FormatIndentDecrease=�5F      �� 5G   
   -   5        $��myRichTB��5G   #   $��3��6    �� 
AcceptsTab$
 True��63   $	��Top=�6E   $��5q�6]    � 	Resources 5H       �� 
TargetType	 �� Property
 �� Value��%X   'J�       �� 5I      " J�6   .�5J      �� 	 �@��Margin$
 0q�6/   5K      5L      5M       � 5N   
   -   5        $��contentFrame��5N   "   $��10��6     � NavigationUIVisibility$ Hidden=�66   � 5O   
   $��4��6    5P      �� 5Q      $	��200 �6#   �� 5R      .+�5T      �� -   5        $��backBtn��5T      $��0��6$   ���#000$��40��6F   ���#A9A9A9$	��0.1q�6g   $��Вернуться��6}   $��20(�6�   6�   �� 5U      -   5        $��sendBtn��5U      $��1��6$   ���#000$��40��6F   ���#A9A9A9$	��0.1q�6g   $��Отправить��6}   $��20(�6�   6�   5V      5W      5X      