# Smart Inventory Management System (SmartInventory)

> **基于 .NET 8 生态构建的工业级智能仓储监控与管理平台**

这是一个前后端分离的现代化桌面应用程序，旨在解决大中型仓库在处理高价值、大批量资产时的监控与管理痛点。系统不仅具备完整的 CRUD 业务逻辑，更通过高级可视化看板与报表导出功能，实现了从数据到决策的闭环。

---

## 🚀 核心亮点

* **高性能数据聚合**：针对 10 万级真实业务记录，采用 **EF Core 异步聚合查询 (LINQ to SQL)**，实现 10 亿级资产总额的秒级统计，有效避免内存溢出与界面假死。
* **深度数据可视化**：深度定制 **DevExpress ChartControl**，通过饼图（语义化红/绿/橙配色）实时监控库存健康分布，配合 Top 10 资产排行实现精准库存预警。
* **企业级报表导出**：集成 **DevExpress Printing 引擎**，攻克 .NET 8 下的进程关联难题，支持看板与列表的一键 PDF/Excel 导出，具备智能分页与比例自适应算法。
* **全流程权限安全**：后端基于 **ASP.NET Core Web API** 构建，集成 **JWT (JSON Web Token)** 认证体系，确保 WinForms 客户端与服务器端的通信安全。
* **现代化 Fluent UI**：利用 **LayoutControl** 实现流式布局，完美适配不同分辨率屏幕，提供极致的桌面交互体验。

---

## 🛠️ 技术栈

| 层次 | 技术选型 |
| :--- | :--- |
| **开发框架** | .NET 8 (LTS) |
| **客户端** | WinForms + DevExpress (Industrial Suite) |
| **服务端** | ASP.NET Core Web API |
| **持久层** | Entity Framework Core + SQL Server |
| **安全/通信** | JWT Authentication + HttpClient Factory |
| **报表引擎** | DevExpress Printing & Export Library |

---

## 📸 界面预览

> **提示**：请在此处上传你的项目截图，增强视觉说服力。

1. **资产看板模块**：实时统计 10 亿级资产分布，内置动态库存预警色块。
2. **库存管理中心**：支持高性能分页加载与多维度组合搜索。
3. **专业报表回执**：一键生成的 A4 比例自适应 PDF 导出预览。

---

## 📥 快速开始

1. **环境要求**：
    * Visual Studio 2022 (v17.8+)
    * SQL Server 2019+
    * DevExpress 23.1+ (或其他兼容版本)

2. **服务端启动**：
    * 修改 `SmartInventory.API` 中的 `appsettings.json` 数据库连接字符串。
    * 在程序包管理器控制台执行 `Update-Database` 进行数据库迁移。
    * 启动 API 项目。

3. **客户端启动**：
    * 启动 `SmartInventory.Client`。
    * 使用内置管理员账号（admin/admin）登录进入监控中心。

---

## 💎 开发心得 (Technical Insights)

本项目在开发过程中攻克了多个实际生产环境中的技术难点：
* **数据库翻译优化**：处理了 `decimal?` 可空类型在 LINQ 聚合运算中的 SQL 翻译兼容性。
* **进程间通信修复**：解决了 .NET 8 环境下 `Process.Start` 调用系统外壳程序时的 `Win32Exception`。
* **业务逻辑感知的 UI 绘制**：利用 `CustomDrawSeriesPoint` 事件将复杂的库存预警逻辑与图表渲染深度绑定。

---

## 📄 开源协议

基于 MIT License 开源。
