# SmartInventory - 工业级智能仓储监控与硬件采集平台

基于 **.NET 8** 生态构建的现代化工业仓储管理方案，成功打通了“底层硬件通讯 -> 边缘网关处理 -> 云端数据持久化”的全链路。

本系统专为处理高价值资产（如 RTX 4090 显卡）的仓储场景设计，集成了工业级扫码枪通讯协议、实时库存大数据看板以及企业级报表引擎。

---

## 🚀 核心亮点

### 1. 工业级多源数据采集 (IoT Gateway)
* **双通道并行通讯**：集成 **RS232 串口 (SerialPort)** 与 **TCP/IP Socket** 监听网关，支持工业扫码枪、PDA及各类传感器接入。
* **异步高性能架构**：基于 .NET 的 **APM (Asynchronous Programming Model)** 模式，通过 `Begin/End` 异步回调处理并发数据流，确保 UI 界面在数据高频吞吐下永不卡死。
* **可靠性闭环机制**：内置应用层 **ACK 确认反馈** 逻辑与心跳检测，有效解决工业现场复杂电磁干扰导致的数据丢失与粘包问题。

### 2. 高性能数据聚合与分析
* **亿级资产统计**：针对 10 万级真实业务记录，采用 **EF Core 异步聚合查询 (LINQ to SQL)**，实现 10 亿级资产总额的秒级统计，彻底杜绝内存溢出风险。
* **深度数据可视化**：深度定制 **DevExpress ChartControl**，配合语义化配色方案（红/绿/橙）实时监控库存健康分布。

### 3. 企业级报表与权限体系
* **智能报表引擎**：集成 DevExpress Printing 引擎，攻克 .NET 8 环境下的进程外壳调用难题，支持看板与列表的一键 PDF/Excel 导出。
* **全流程安全体系**：后端基于 ASP.NET Core API 构建，集成 **JWT (JSON Web Token)** 认证体系，确保边缘节点与云端通信的安全。

---

## 🛠️ 技术栈

| 层次 | 技术选型 | 核心优势 |
| :--- | :--- | :--- |
| **开发框架** | **.NET 8 (LTS)** | 微软最新长期支持版本，极高的执行效率 |
| **客户端 UI** | **WinForms + DevExpress (Industrial Suite)** | Fluent Design 现代布局，支持 DPI 自适应 |
| **硬件通讯** | **System.IO.Ports + System.Net.Sockets** | 原生异步串口、高性能 TCP 服务端封装 |
| **持久层** | **Entity Framework Core + SQL Server** | 强类型 ORM 映射，复杂业务逻辑高效表达 |
| **安全/通信** | **JWT Authentication + HttpClient Factory** | 安全、标准化的边缘节点与云端 API 通信 |
| **报表导出** | **DevExpress Printing & Export Library** | 像素级精准导出与 A4 比例自适应算法 |

---

## 📸 界面预览

> **提示**：建议在此处上传你的实际运行截图。

1. **硬件监控中心**：左侧实时展示串口与网络监听状态，右侧高亮显示入库成功记录，内置原始 Hex/ASCII 日志追踪。
2. **资产看板模块**：动态展示 10 亿级资产分布，多维饼图与 Top 10 排行列表联动。
3. **库存管理中心**：支持全表模糊搜索、高性能分页加载及动态状态色块显示。

---

## 📥 快速开始

### 环境要求
* Visual Studio 2022 (v17.8+)
* SQL Server 2019+
* DevExpress 23.1+ (或其他兼容版本)
* 虚拟串口工具 (VSPD) 或 物理串行扫码设备

### 启动流程
1. **服务端**：配置 `SmartInventory.API` 中的数据库连接字符串，执行 `Update-Database` 后启动 API。
2. **客户端**：启动 `SmartInventory.Client`，在“硬件中心”选择对应 COM 口或设定 TCP 监听端口（默认 8080）。
3. **模拟测试**：通过网络调试助手发送 SN 码（如 `SN2026RTX4090001`），观察系统自动解析入库并实时反馈 `OK` 信号。

---

## 💎 技术心得 (Technical Insights)

本项目在开发过程中攻克了多个工业场景下的真实痛点，体现了对 .NET 底层机制的掌握：

* **跨线程 UI 同步**：深入应用 `this.Invoke` 机制，解决了异步 Socket 回调线程直接访问 UI 控件导致的 `InvalidOperationException` 异常。
* **异步资源闭环管理**：通过 `IAsyncResult` 状态追踪与 `Shutdown/Close` 协议，实现了 Socket 服务的优雅关闭，防止端口非法占用与内存泄漏。
* **数据库翻译优化**：通过对 LINQ 表达式的深度优化，解决了 `decimal?` 可空类型在高并发聚合运算中的 SQL 翻译兼容性问题。
* **健壮性代码设计**：在 APM 异步模型中引入双重保护逻辑，有效规避了在极端断线场景下的空对象引用 (NullReference) 竞态问题。

---

## 📄 开源协议

基于 **MIT License** 开源。
