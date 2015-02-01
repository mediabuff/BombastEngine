#pragma once

#include <QtWidgets/QMainWindow>
#include "ui_bombasteditormain.h"
class BombastEditorMain : public QMainWindow
{
	Q_OBJECT

public:
	BombastEditorMain(QWidget *parent = 0);
	~BombastEditorMain();

private:
	void InitEngine();

	void closeEvent(QCloseEvent* event);

private:

	Ui::BombastEditor ui;
};